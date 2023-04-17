using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/User/{id}/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyService _iSpecialtyService;
        public SpecialtyController(ISpecialtyService iSpecialtyService)
        {
            _iSpecialtyService = iSpecialtyService;
        }
        [HttpPost]
        public IActionResult Post(int id, AddSpecialtyInputModel model)
        {
            var specialty = _iSpecialtyService.Create(id, model);
            return Ok();
        }
    }
}
