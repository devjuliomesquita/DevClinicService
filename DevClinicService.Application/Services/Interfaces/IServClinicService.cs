using DevClinicService.Application.InputModels;
using DevClinicService.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Interfaces
{
    public interface IServClinicService
    {
        List<ServiceViewModel> GetAll(string query);
        ServiceDetailsViewModel GetById(int id);
        int Create(int id, AddServiceInputModel model);
        void Delete(int id);
        void Start(int id);
        void Finish(int id);
    }
}
