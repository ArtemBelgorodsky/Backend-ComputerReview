using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComputerInfoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ComputerInfoController> _logger;

        public ComputerInfoController(ILogger<ComputerInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<IComputerInfo> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new IComputerInfo
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
