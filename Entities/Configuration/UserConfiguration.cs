using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    FirstName = "Administrator",
                    LastName = "Administrator",
                    UserName = "Administrator",
                    Email = "admin@gmail.com",
                    IsEnabled = true,
                    PhoneNumber = "+251-944-69-69-69",
                    NormalizedUserName = "ADMINISTRATOR",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==",
                    SecurityStamp = "AX4V5FQG663Z44N46VMUANNWRVJRMFHW",
                    ConcurrencyStamp = "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true
                }
            );
        }
    }
}
