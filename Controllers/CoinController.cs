using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitmarker.Controllers
{
    [Route("api/coin")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        [HttpGet("GetCoinAll123")]
        public async Task<IActionResult> GetCoinAll()
        {
            return Ok(true);
        }
    }
}
