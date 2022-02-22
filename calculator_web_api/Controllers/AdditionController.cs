using Microsoft.AspNetCore.Mvc;
using calculator_library;


namespace calculator_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        Calculator calc = new Calculator();

        [HttpGet]
        public double add(double num1, double num2)
        {
            
            return calc.addition(num1, num2);
        }
    }
}