using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Service.Abstract;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Validation;
using FluentValidation;
using Serilog;

namespace ShoppingApi.Controllers
{   
    [ApiController]
    [Route("[controller]s")]
    public class ProductController : ControllerBase
    {
        public readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            Log.Debug("Product/GetAll");

            var products =await service.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            Log.Debug("Product/GetByID");

            var product=await service.GetByIdAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductDto createModel)
        {
            Log.Debug("Product/Post");

            ProductValidation validator = new ProductValidation();
            validator.ValidateAndThrow(createModel);

            await service.Insert(createModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log.Debug("Product/Delete");

            await service.Delete(id);
            return Ok();
        }
    }
}
