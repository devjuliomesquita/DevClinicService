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


        public int Create(int id, AddSpecialtyInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            if(user == null) { return -1; }
            var userSpecilty = new Specialty(model.Description, user.Id);
            _context.Specialties.Add(userSpecilty);
            _context.SaveChanges();
            return userSpecilty.Id;
        }
    }
}
