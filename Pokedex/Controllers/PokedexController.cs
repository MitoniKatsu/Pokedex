using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pokedex.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokedexController : ControllerBase
    {
        private readonly ILogger<PokedexController> _logger;

        public PokedexController(ILogger<PokedexController> logger)
        {
            _logger = logger;
        }
    }
}
