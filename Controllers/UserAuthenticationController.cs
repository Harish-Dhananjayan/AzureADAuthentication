using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureADClientSideAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserAuthenticationController : ControllerBase
    {
        [HttpGet("user-authetication")]
        public IActionResult SampleAction()
        {
            string? username = User.Identity.Name; 
            string message = $"Hello, {username}! This is a protected resource.";
            return Ok(new { Message = message });
        }

    }
}
