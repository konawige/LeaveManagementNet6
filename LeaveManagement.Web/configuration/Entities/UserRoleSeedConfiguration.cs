using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac2e8c7-5ad6-43e5-baaf-a332c9322a8c",
                    UserId = "c532e8c6-5fd6-43e5-baaf-a332c9322a9d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "dfd2e8c7-5ad4-43e5-deaf-a332c9322a8r",
                    UserId = "e4425472-79e5-4da5-832e-1e43ad0bcd97"
                }

                );
        }
    }
}