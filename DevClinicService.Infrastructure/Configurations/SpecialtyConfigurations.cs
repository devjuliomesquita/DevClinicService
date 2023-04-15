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
    public class SpecialtyConfigurations : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder
                .HasKey(s =>  s.Id);
        }
    }
}
