using DevClinicService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Infrastructure.Persistence
{
    public class DevClinicServiceContext : DbContext
    {
        public DevClinicServiceContext(DbContextOptions<DevClinicServiceContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Specialty> Specialties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
