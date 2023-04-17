using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
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
        private readonly IServClinicService _servClinicService;
        public ServiceClinicController(IServClinicService servClinicService)
        {
            _servClinicService = servClinicService;
        }

        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var services = _servClinicService.GetAll(query);
            return Ok(services);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var service = _servClinicService.GetById(id);
            if(service == null) { return NotFound(); }
            return Ok(service);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AddServiceInputModel model)
        {

            var id = _servClinicService.Create(model);

            return CreatedAtAction(nameof(GetById), new {Id = id }, model);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _servClinicService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}/Start")]
        public IActionResult Start(int id)
        {
            _servClinicService.Start(id);
            return NoContent();
        }
        [HttpPut("{id}/Finish")]
        public IActionResult Finish(int id)
        {
            _servClinicService.Finish(id);
            return NoContent();
        }
    }
}
