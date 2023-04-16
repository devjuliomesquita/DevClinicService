using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.ViewModels
{
    public record ServiceDetailsViewModel(
        int Id,
        string Token,
        DateTime CreatedAt,
        DateTime FinishedAt,
        string Client,
        string Doctor,
        string Specialty,
        string Status)
    {
    }
}
