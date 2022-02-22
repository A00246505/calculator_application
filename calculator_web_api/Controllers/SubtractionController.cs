using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using calculator_library;


namespace calculator_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtractionController : ControllerBase
    {
        Calculator calc = new Calculator();

        [HttpGet]
        public double sub(double num1, double num2)
        {

            return calc.subtraction(num1, num2);
        }
    }
}