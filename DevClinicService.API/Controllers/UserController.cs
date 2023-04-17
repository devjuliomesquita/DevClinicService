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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var clients = _userService.GetAll(query);
            return Ok(clients);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var client = _userService.GetById(id);
            if(client == null) { NotFound(); }

            return Ok(client);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AddUserInputModel model)
        {
            var id = _userService.Create(model);
            return CreatedAtAction(nameof(GetById) , new {Id = id}, model);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateUserInputModel model)
        {
            _userService.Update(id, model);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UserCancel(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
