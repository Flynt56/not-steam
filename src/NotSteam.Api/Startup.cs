using System;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NotSteam.Api.Services;
using NotSteam.Core.App.Games.Commands.AddGame;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.Extensions;
using NotSteam.Core.Filters;
using NotSteam.Core.Infrastructure;
using NotSteam.Core.Infrastructure.AutoMapper;
using NotSteam.Core.Interfaces.Logging;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Services;
using NotSteam.Infrastructure.DB;
using NotSteam.Infrastructure.Identity;
using NotSteam.Infrastructure.Interfaces.Repositories;
using NotSteam.Infrastructure.Interfaces.Services;
using NotSteam.Infrastructure.Logging;
using NotSteam.Infrastructure.Repositories;
using NotSteam.Infrastructure.Services;

namespace NotSteam
{
    public class Startup
    {
        public readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddAutoMapper(new Assembly[]
            {
                typeof(AutoMapperProfile).GetTypeInfo().Assembly
            });

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            services.AddDbContext<NotSteamContext>(options =>
                options
                    .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                    opt => opt.MigrationsAssembly("NotSteam.Infrastructure")));

            services.AddIdentity<AuthUser, AuthRole>()
                .AddEntityFrameworkStores<NotSteamContext>()
                .AddDefaultTokenProviders();

            // Repositories
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();

            // Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthUserService, AuthUserService>();

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // Remove default claims
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = Configuration["JwtIssuer"],
                        ValidAudience = Configuration["JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
                        ClockSkew = TimeSpan.Zero // Remove token expiration delay
                    };
                });

            // Add MediatR
            services.AddMediatR(new Assembly[]
            {
                typeof(GetGameDetailRequestHandler).GetTypeInfo().Assembly
            });

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services.AddMvc(opt => opt.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(a => a.RegisterValidatorsFromAssemblyContaining<AddGameCommandValidator>());

            FluentValidation.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("hr");
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseApiCors();
        }
    }
}
