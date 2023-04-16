using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.ViewModels
{
    public record ServiceViewModel(
        int Id,
        string Token,
        DateTime CreatedAt)
    {
    }
}
