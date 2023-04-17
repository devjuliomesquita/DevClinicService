using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.InputModels
{
    public record AddServiceInputModel(
        int IdClient,
        int IdDoctor
        )
    {
    }
}
