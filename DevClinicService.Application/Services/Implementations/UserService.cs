using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Application.ViewModels;
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
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
