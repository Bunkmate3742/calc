using Microsoft.AspNetCore.Mvc;
using System;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly string _name;

        public GreetingController()
        {
            _name = Environment.GetEnvironmentVariable("NAME") ?? "World";
        }

        [HttpGet]
        public IActionResult Get()
        {
            string message = $"Hello, {_name}!";
            return Ok(message);
        }
    }
}
