using Microsoft.AspNetCore.Mvc;
using System;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("calculate")]
    public class GreetingController : ControllerBase
    {
        private readonly string _name;

        public GreetingController()
        {
            _name = Environment.GetEnvironmentVariable("NAME") ?? "World";
        }

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     string message = $"Hello, {_name}!";
        //     return Ok(message);
        // }

        [HttpGet("{numOneStr}/{actionStr}/{numTwoStr}")]
        public IActionResult Calc(string numOneStr, string actionStr, string numTwoStr)
        {
            double numOne = Convert.ToDouble(numOneStr);
            double numTwo = Convert.ToDouble(numTwoStr);
            double result;
            
            switch(actionStr) 
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
