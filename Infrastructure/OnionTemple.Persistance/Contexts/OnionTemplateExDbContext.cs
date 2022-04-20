using Microsoft.EntityFrameworkCore;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts.EntityMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Contexts
{
    public class OnionTemplateExDbContext : DbContext
    {
        public OnionTemplateExDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CountryMap());
        }
    }
    
}
