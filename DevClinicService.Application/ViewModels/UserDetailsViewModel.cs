using DevClinicService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.ViewModels
{
    public record UserDetailsViewModel(
        string Firstname,
        string LastName,
        string Email,
        string CPF,
        string Specialty
        )
    {
    }
}
