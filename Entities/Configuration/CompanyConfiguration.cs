using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
                new Company
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Inventory",
                    Address = "Ethiopia addis ababa",
                    PhoneNo = "+251-",
                    Email = "inventory@gmail.com",
                    Fax = "00000",
                    Website="https://www.inventory.com",
                    Description="inventory Company",
                    Country ="Ethiopia"

    }
            );
        }
    }
}
