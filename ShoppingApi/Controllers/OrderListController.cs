using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class OrderListController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
