using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public string MethodOne()
        {
            try
            {
                return "MethodOne is called successfully";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}. ->>> {ex.InnerException}";
            }
        }
    }
}
