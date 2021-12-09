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
                    Name = "Awach SACCOS",
                    Address = "Aware around Edna Addis Hotel at Agar Building",
                    PhoneNo = "+251-118-12-44-44",
                    Email = "awach@gmail.com",
                    Fax = "34752",
                    Website="https://www.awach.com",
                    Description="SACCOS Company",
                    Country ="Ethiopia"

    }
            );
        }
    }
}
