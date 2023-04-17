using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Implementations
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly DevClinicServiceContext _context;
        public SpecialtyService(DevClinicServiceContext context)
        {
            _context = context;
        }

        public int Create(AddSpecialtyInputModel model)
        {
            var specialty = new Specialty(model.Description);
            _context.Specialties.Add(specialty);
            _context.SaveChanges();
            return specialty.Id;
        }
    }
}
