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

        [HttpPost("GramsToOunces")]
        public ActionResult<double> GramsToOunces(double grams)
        {
            try
            {
                return Ok(grams / 28.35);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("OuncesToGrams")]
        public ActionResult<double> OuncesToGrams(double ounce)
        {
            try
            {
                return Ok(ounce * 28.35);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("LitresToPints")]
        public ActionResult<double> LitresToPints(double litres)
        {
            try
            {
                return Ok(litres * 1.76);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("PintsToLitres")]
        public ActionResult<double> PintsToLitres(double pints)
        {
            try
            {
                return Ok(pints / 1.76);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("CelsiusToFahrenheit")]
        public ActionResult<double> CelsiusToFahrenheit(double celsius)
        {
            try
            {
                return Ok(((celsius * 9) / 5) + 32);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }


        [HttpPost("FahrenheitToCelsius")]
        public ActionResult<double> FahrenheitToCelsius(double fahrenheit)
        {
            try
            {
                return Ok((fahrenheit - 32) * 5 / 9);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }


        [HttpPost("KilometerToMiles")]
        public ActionResult<double> KilometerToMiles(double kilometers)
        {
            try
            {
                return Ok(kilometers / 1.6);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("MilesToKilometer")]
        public ActionResult<double> MilesToKilometer(double miles)
        {
            try
            {
                return Ok(miles * 1.609344);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
