using DevClinicService.Application.InputModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace DevClinicService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceClinicController : ControllerBase
    {
        private readonly DevClinicServiceContext _context;
        public ServiceClinicController(DevClinicServiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var services = _context.Services;
            return Ok(services);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);
            if(service == null) { return NotFound(); }
            return Ok(service);
        }
        [HttpPost]
        public IActionResult Post(AddServiceInputModel model)
        {
            var token = "123";
            var service = new Service(
                model.IdCLient,
                model.IdDoctor,
                token);
            _context.Services.Add(service);
            return Ok();
        }
        [HttpPut("id")]
        public IActionResult Put(int id)
        {
            return Ok();
        }
    }
}
