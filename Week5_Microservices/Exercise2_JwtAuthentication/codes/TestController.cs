using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]   //anyone can access this endpoint
        public IActionResult PublicEndpoint()
        {
            return Ok("This is a public endpoint.");
        }

        [Authorize]    //lets only users with verified tokens 
        [HttpGet("private")]   //only users with token can access this endpoint
        public IActionResult PrivateEndpoint()       //endpoint to check validity of token
        {
            return Ok("This is a private endpoint protected by JWT.");
        }
    }
}
