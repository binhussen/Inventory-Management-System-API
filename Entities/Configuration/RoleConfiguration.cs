using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
              new IdentityRole
              {
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR"
              },
              new IdentityRole
              {
                  Name = "Purchaser",
                  NormalizedName = "PURCHASER"
              },
              new IdentityRole
              {
                  Name = "StoreMan",
                  NormalizedName = "STOREMAN"
              },
              new IdentityRole
              {
                  Name = "DepartmentHead",
                  NormalizedName = "DEPARTMENTHEAD"
              },
              new IdentityRole
              {
                  Name = "FinanceManager",
                  NormalizedName = "FINANCEMANAGER"
              },
              new IdentityRole
              {
                  Name = "ProcurementManager",
                  NormalizedName = "PROCUREMENTMANAGER"
              }
            );
        }
    }
}
