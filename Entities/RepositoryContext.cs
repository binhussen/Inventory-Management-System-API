using Entities.Common;
using Entities.Configuration;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RepositoryContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RequestHeader> RequestHeaders { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<StoreHeader> StoreHeaders { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }

        /*audit*/
        public string GetCurrentUsername()
        {
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcessSave();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void ProcessSave()
        {
            var currentTime = DateTimeOffset.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is BaseEntity))
            {
                var entidad = item.Entity as BaseEntity;
                entidad.CreatedDate = currentTime;
                entidad.CreatedByUser = GetCurrentUsername();
                entidad.ModifiedDate = currentTime;
                entidad.ModifiedByUser = GetCurrentUsername();
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(predicate: e => e.State == EntityState.Modified && e.Entity is BaseEntity))
            {
                var entidad = item.Entity as BaseEntity;
                entidad.ModifiedDate = currentTime;
                entidad.ModifiedByUser = GetCurrentUsername();
                item.Property(nameof(entidad.CreatedDate)).IsModified = false;
                item.Property(nameof(entidad.CreatedByUser)).IsModified = false;
            }
        }
    }
}