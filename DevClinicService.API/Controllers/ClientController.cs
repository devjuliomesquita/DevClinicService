using DevClinicService.Application.InputModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DevClinicServiceContext _context;
        public ClientController(DevClinicServiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _context.Users.Select(c => c.IsSpecialty == false);
            return Ok(clients);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var client = _context.Users.SingleOrDefault(c => c.Id == id);
            if(client == null) { NotFound(); }

            return Ok(client);
        }
        [HttpPost]
        public IActionResult Post(AddClientInputModel model)
        {
            var client = new User(
                model.FirstName,
                model.LastName,
                model.Email,
                model.CPF,
                model.Password);
            _context.Users.Add(client);
            return CreatedAtAction("GetById" , new {id = client.Id}, client);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateClientInputModel model)
        {
            var client = _context.Users.SingleOrDefault(c => c.Id == id);
            if (client == null) { NotFound(); }
            client!.Update(
                model.FirstName,
                model.LastName,
                model.Email,
                model.CPF,
                model.Password);
            return Ok();
        }
    }
}
