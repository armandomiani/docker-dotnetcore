using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Miani.DotNetDocker.Controllers
{    
    [ApiController]
    [Produces("application/json")]
    [Route("/[controller]")]
    public class RoomsController : ControllerBase 
    {
        [HttpGet(Name = nameof(GetRooms))]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult GetRooms() 
        {
            var response = new {
                href = "xxx"
            };

            return Ok(response);
        }
    }
}