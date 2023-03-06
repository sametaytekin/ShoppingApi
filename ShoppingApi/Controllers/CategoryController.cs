using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Abstract;
using ShoppingApi.Service.Concrete;
using ShoppingApi.Service.Validation;

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
            Log.Debug("Category/GetAll");

            var allCategory= await service.GetAllAsync();
            return Ok(allCategory);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log.Debug("Category/GetById");

            var categoryByID = await service.GetByIdAsync(id);
            return Ok(categoryByID);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDto postModel)
        {
            Log.Debug("Category/Post");

            var validator=new CategoryValidation();
            validator.ValidateAndThrow(postModel);

            await service.Insert(postModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id )
        {
            Log.Debug("Category/Delete");
            await service.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryDto updateModel)
        {
            Log.Debug("Category/Put");

            var validator = new CategoryValidation();
            validator.ValidateAndThrow(updateModel);

            await service.Update(id,updateModel);
            return Ok();
        }
    }
}
