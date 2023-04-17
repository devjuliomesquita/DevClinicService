using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Application.ViewModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevClinicServiceContext _context;
        public UserService(DevClinicServiceContext context)
        {
            _context = context;
        }
        public int Create(AddUserInputModel model)
        {
            var user = new User(model.FirstName, model.LastName, model.Email, model.CPF, model.Password);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public List<UserViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            if(user == null) { return null; }
            return new UserViewModel(user.FirstName, user.LastName, user.CPF);
        }
    }
}
