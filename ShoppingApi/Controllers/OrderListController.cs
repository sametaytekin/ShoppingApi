using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Abstract;
using ShoppingApi.Service.Validation;

namespace ShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class OrderListController : ControllerBase
    {
        public readonly IOrderListService service;

        public OrderListController(IOrderListService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            Log.Debug("OrderList/GetAll");

            var orderLists =await service.GetAllAsync();
            return Ok(orderLists);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Log.Debug("OrderList/GetByID");

             var orderList =await service.GetByIdAsync(id);

            return Ok(orderList);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderListDto createModel)
        {
            Log.Debug("OrderList/Post");

            OrderListValidation validator = new OrderListValidation();
            validator.ValidateAndThrow(createModel);

            await service.Insert(createModel);

            return Ok();
        }

    }
}
