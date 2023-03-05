using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class UserController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
