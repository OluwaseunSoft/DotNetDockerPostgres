using DotNetDockerPostgres.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDockerPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly ConversionRateDBContext _context;

        public ConversionController(ConversionRateDBContext context)
        {
            _context = context;
        }

        [HttpPost("CentimeterToInches")]
        public ActionResult<double> CentimeterToInches(double centimeters)
        {
            try
            {
                return Ok(centimeters / 2.54);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }


        [HttpPost("InchesToCentimeters")]
        public ActionResult<double> InchesToCentimeters(double inches)
        {
            try
            {
                return Ok(inches * 2.54);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
