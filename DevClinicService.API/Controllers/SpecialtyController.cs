using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyService _iSpecialtyService;
        public SpecialtyController(ISpecialtyService iSpecialtyService)
        {
            _iSpecialtyService = iSpecialtyService;
        }
        [HttpPost]
        public IActionResult Post(AddSpecialtyInputModel model)
        {
            var specialty = _iSpecialtyService.Create(model);
            if (specialty == null) { NotFound(); }
            return Ok();
        }
    }
}
