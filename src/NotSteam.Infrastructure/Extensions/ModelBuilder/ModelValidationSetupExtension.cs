using NotSteam.Model.Models;

namespace NotSteam.Core.Extensions.ModelBuilder
{
    public static class ModelBuilderModelValidationSetupExtension
    {
        public static void ValidationSetup(this Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            User(modelBuilder);
        }

        private static void User(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}

