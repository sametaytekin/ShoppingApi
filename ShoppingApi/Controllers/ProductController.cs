using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers
{   
    [ApiController]
    [Route("[controller]s")]
    public class ProductController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
