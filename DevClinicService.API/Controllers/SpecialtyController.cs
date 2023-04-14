using DevClinicService.Application.InputModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/Doctor/{id}/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly DevClinicServiceContext _context;
        public SpecialtyController(DevClinicServiceContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(int id, AddSpecialtyInputModel model)
        {
            var doctor = _context.Users.Where(c => c.IsSpecialty == true).SingleOrDefault(c => c.Id == id);
            if (doctor == null) { NotFound(); }
            var specialty = new UserSpecialty(
                id,
                model.Description);
            doctor!.Specialties.Add(specialty);
            return Ok();
        }
    }
}
