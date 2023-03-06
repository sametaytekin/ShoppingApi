using FluentValidation;
using ShoppingApi.Dto.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Validation
{
    public class OrderListValidation:AbstractValidator<OrderListDto>
    {
        public OrderListValidation()
        {
            
            RuleFor(x=> x.Name).NotEmpty().NotNull();
            RuleFor(x=>x.CategoryId).NotNull();
        }
    }
}
