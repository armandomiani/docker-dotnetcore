using System.Net;
using Microsoft.AspNetCore.Mvc;


namespace Miani.DotNetDocker.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult GetRoot() 
        {
            var response = new {
                href = Url.Link(nameof(GetRoot), null),
                rooms = Url.Link(nameof(RoomsController.GetRooms), null)
            };

            return Ok(response);
        }
    }
}