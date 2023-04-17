using DevClinicService.Application.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Interfaces
{
    public interface ISpecialtyService
    {
        int Create(int id, AddSpecialtyInputModel model);
    }
}
