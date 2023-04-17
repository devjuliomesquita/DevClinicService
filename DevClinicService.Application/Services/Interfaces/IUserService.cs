using DevClinicService.Application.InputModels;
using DevClinicService.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetAll(string query);
        UserDetailsViewModel GetById(int id);
        int Create(AddUserInputModel model);
        void Update(int id, UpdateUserInputModel model);
        void Delete(int id);
        
    }
}
