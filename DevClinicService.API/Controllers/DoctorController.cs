﻿using DevClinicService.Application.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinicService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(AddDoctorInputModel model)
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateDoctorInputModel model)
        {
            return Ok();
        }
    }
}
