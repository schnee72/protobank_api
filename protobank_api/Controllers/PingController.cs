using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace protobank_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Ping")]
    public class PingController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "pong";
        }

        [HttpGet("two")]
        public string GetTwo()
        {
            return "pong2";
        }
    }
}