using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace testappmac.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StupidController : MyControllerBase
    {
        

        private readonly ILogger<StupidController> _logger;

        public StupidController(ILogger<StupidController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {

            return "Stupid Controller Does Nothing";
        }
    }
}
