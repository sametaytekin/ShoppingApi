using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers
{   
    [ApiController]
    [Route("[controller]s")]
    public class CategoryController : ControllerBase
    {
        public async Task<IActionResult> GetAll()
        {

            return Ok();
        }
    }
}
