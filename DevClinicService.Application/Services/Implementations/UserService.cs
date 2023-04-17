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

        public void Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            user!.UserCancel();
            _context.SaveChanges();
        }

        public List<UserViewModel> GetAll(string query)
        {
            var user = _context.Users;
            var userViewModel = user
                .Select(uv => new UserViewModel(uv.FirstName, uv.LastName, uv.CPF))
                .ToList();
            return userViewModel;
        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            if(user == null) { return null; }
            var specialty = _context.Specialties.SingleOrDefault(s => s.IdUser == id);
            return new UserDetailsViewModel(
                user.FirstName, 
                user.LastName, 
                user.Email,
                user.CPF,
                specialty!.Description);
        }

        public void Update(int id, UpdateUserInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            user!.Update(
                model.FirstName,
                model.LastName,
                model.Email,
                model.CPF,
                model.Password);
            _context.SaveChanges();
        }
    }
}
