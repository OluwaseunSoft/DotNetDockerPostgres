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

        [HttpGet]
        public ActionResult<IEnumerable<Unit>> GetPlatforms()
        {
            try
            {
                System.Console.WriteLine("==> Getting Platforms");

                var platformItem = _context.Units.ToList();
                return Ok(platformItem);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
