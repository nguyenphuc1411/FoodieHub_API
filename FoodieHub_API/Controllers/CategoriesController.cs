﻿using FoodieHub_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodieHub_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var response = await _service.GetAll();
            return StatusCode(response.StatusCode, response);
        }
        [HttpGet("example")]
        public async Task<ActionResult> GetExample()
        {
            var response = await _service.GetExample();
            return StatusCode(response.StatusCode, response);
        }
    }
}
