using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Welcome : ControllerBase
    {
        private class WelcomeMessage
        {
            public int Number { get; set; }
            public string Text { get; set; }
        }

         List<WelcomeMessage> list = new List<WelcomeMessage>
        {
            new WelcomeMessage(){Number=1,Text="Welcome"},
            new WelcomeMessage(){Number=2,Text="Merhaba"}
        };
       

        public string Message()
        {
            return "Welcome";
        }

        [HttpGet]
        public IActionResult Start()
        {
            if (list == null)
            {
                return BadRequest(list);
            }
            return Ok(list);
        }
    }
}
