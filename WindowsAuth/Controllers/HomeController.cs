using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WindowsAuth.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[AllowAnonymous]
    [Authorize]
    [EnableCors("CorsPolicy")]
    public class HomeController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string? _user;
        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _user = _httpContextAccessor.HttpContext?.User.Identity?.Name;
        }
        [HttpGet]
        public string MethodOne()
        {
            try
            {
                string? username = _user;
                return $"MethodOne is called successfully. Username {username}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}. ->>> {ex.InnerException}";
            }
        }
    }
}
