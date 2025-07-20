using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult PublicEndpoint()           //anybody can access this endpoint
        {
            return Ok("This is a public endpoint.");
        }

        [Authorize]
        [HttpGet("private")]
        public IActionResult PrivateEndpoint()              //only users with JWT can access this endpoint
        {
            return Ok("This is a private endpoint protected by JWT.");
        }
    }
}
