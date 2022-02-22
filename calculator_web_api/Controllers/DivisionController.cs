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
    public class DivisionController : ControllerBase
    {
        Calculator calc = new Calculator();

        [HttpGet]
        public double divide(double num1, double num2)
        {

            return calc.division(num1, num2);
        }
    }
}