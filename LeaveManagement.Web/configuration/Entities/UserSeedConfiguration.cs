using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

namespace LeaveManagement.Web.configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {

            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "c532e8c6-5fd6-43e5-baaf-a332c9322a9d",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new Employee
                {
                    Id = "e4425472-79e5-4da5-832e-1e43ad0bcd97",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "USER@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "User",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "P@ssword2")
                }
            );
        }
    }
}