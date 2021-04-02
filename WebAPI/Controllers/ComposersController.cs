using ItSays.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComposersController : ControllerBase
    {
        private IComposerService _composerService;
        public ComposersController(IComposerService composerService)
        {
            _composerService = composerService;
        }

        [HttpGet("getcomposersall")]
        public IActionResult GetAllComposers()
        {
            var result = _composerService.GetComposerDetails();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       
    }
}
