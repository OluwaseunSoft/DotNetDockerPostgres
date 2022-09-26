using DotNetDockerPostgres.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDockerPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionTableRepo _repo;

        public ConversionController(IConversionTableRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("CreateMetricUnit")]
        public ActionResult<Unit> CreateMetricUnit(UnitCreateDto createDto)
        {
            var data = new Unit
            {
                MetricUnit = createDto.MetricUnit,
                MetricValue = createDto.MetricValue
            };
            _repo.CreateConversionUnit(data);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetMetricUnitId), new { Id = data.Id }, data);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Unit>> GetMetricUnits()
        {
            var unitList = _repo.GetAllConversionUnit();
            return Ok(unitList);
        }

        [HttpGet("id", Name = "GetMetricUnitId")]
        public ActionResult<Unit> GetMetricUnitId(int id)
        {
            var unit = _repo.GetConversionUnitById(id);
            return Ok(unit);
        }

        [HttpPost("CentimeterToInches")]
        public ActionResult<double> CentimeterToInches(double centimeters)
        {
            try
            {
                var unit = _repo.GetConversionUnitById(1);
                return Ok(centimeters / double.Parse(unit.MetricValue));
            }
            catch (Exception ex)
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
                var unit = _repo.GetConversionUnitById(2);
                return Ok(inches * double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(3);
                return Ok(grams / double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(4);
                return Ok(ounce * double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(5);
                return Ok(litres * double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(6);
                return Ok(pints / double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(7);
                return Ok(((celsius * 9) / 5) + double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(8);
                return Ok((fahrenheit - double.Parse(unit.MetricValue)) * 5 / 9);
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
                var unit = _repo.GetConversionUnitById(10);
                return Ok(kilometers / double.Parse(unit.MetricValue));
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
                var unit = _repo.GetConversionUnitById(9);
                return Ok(miles * double.Parse(unit.MetricValue));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
