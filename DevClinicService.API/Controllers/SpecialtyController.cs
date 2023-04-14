using DevClinicService.Application.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/Doctor/{id}/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(int id, AddSpecialtyInputModel model)
        {
            return Ok();
        }
    }
}
