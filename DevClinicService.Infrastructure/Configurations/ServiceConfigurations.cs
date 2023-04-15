using DevClinicService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Infrastructure.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .HasKey(s => s.Id);
                
            builder
                .HasOne(s => s.Doctor)
                .WithMany(s => s.DoctorService)
                .HasForeignKey(s => s.IdDoctor)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(s => s.Client)
                .WithMany(s => s.ClientService)
                .HasForeignKey(s => s.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
