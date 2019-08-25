﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NotSteam.Api.Extensions;
using NotSteam.Core.Infrastructure.AutoMapper;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Core.App.Games.Commands.AddGame;
using NotSteam.Api.Filters;
using NotSteam.Core.Interfaces;
using NotSteam.Infrastructure.Logging;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Infrastructure.Repositories;
using NotSteam.Core.Interfaces.Services;
<<<<<<< HEAD
using NotSteam.Api.Services;
=======
using NotSteam.Core.Services;
>>>>>>> feature-overhaul-mediatr

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

<<<<<<< HEAD
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
=======
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
>>>>>>> feature-overhaul-mediatr

            services.AddDbContext<NotSteamContext>(options =>
                options
                    .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                    opt => opt.MigrationsAssembly("NotSteam.Infrastructure")));

            services.AddIdentity<AuthUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<NotSteamContext>()
                .AddDefaultTokenProviders();

<<<<<<< HEAD
=======
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped<IGameRepository, GameRepository>();

>>>>>>> feature-overhaul-mediatr
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

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGameService, GameService>();

            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped<IGameRepository, GameRepository>();

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
