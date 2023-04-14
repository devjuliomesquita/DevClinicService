using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.InputModels
{
    public record UpdateDoctorInputModel(
        string FirstName,
        string lastName,
        string Email,
        string CPF,
        string Password)
    {
    }
}
