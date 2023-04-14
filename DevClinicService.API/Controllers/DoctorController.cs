using DevClinicService.Application.InputModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DevClinicServiceContext _context;
        public DoctorController(DevClinicServiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var doctors = _context.Users.Select(d => d.IsSpecialty == true);
            return Ok(doctors);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var doctor = _context.Users.FirstOrDefault(d => d.Id == id);
            if(doctor == null) { return NotFound(); }
            return Ok(doctor);
        }
        [HttpPost]
        public IActionResult Post(AddDoctorInputModel model)
        {
            var doctor = new User(
                model.FirstName,
                model.LastName,
                model.Email,
                model.CPF,
                model.Password);
            _context.Users.Add(doctor);
            doctor.IsSpecialtyDoctor();
            return CreatedAtAction("GetById", new {id = doctor.Id}, doctor);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateDoctorInputModel model)
        {
            var doctor = _context.Users.FirstOrDefault(d => d.Id == id);
            if (doctor == null) { return NotFound(); }
            doctor.Update(
                model.FirstName,
                model.LastName,
                model.Email,
                model.CPF,
                model.Password);

            return Ok();
        }
    }
}
