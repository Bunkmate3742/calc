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

        [HttpGet("{numOne}/{action}/{numTwo}")]
        public IActionResult Calc(double numOne, string action, double numTwo)
        {
            double result;
            
            switch(action) 
            {
              case "ADD":
                result = numOne + numTwo;
                break;
              case "SUBTRACT":
                result = numOne + numTwo;
                break;
              case "MULTIPLY":
                result = numOne * numTwo;
                break;
              case "DIVIDE":
                result = numOne / numTwo;
                break;
              default:
                return BadRequest("Bad Action Given.");
            }
            
            return Ok(result);
        }
    }
}
