using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Abstract;
using ShoppingApi.Service.Concrete;

namespace ShoppingApi.Controllers
{   
    [ApiController]
    [Route("[controller]s")]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allCategory= await service.GetAllAsync();
            return Ok(allCategory);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var categoryByID = await service.GetByIdAsync(id);
            return Ok(categoryByID);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDto postModel)
        {
            await service.Insert(postModel);
            return Ok();
        }
    }
}
