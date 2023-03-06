using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApi.Dto.DTOs;

namespace ShoppingApi.Service.Validation
{
    public class ProductValidation:AbstractValidator<ProductDto>
    {
        public ProductValidation()
        {
            RuleFor(x=>x.Quantity).GreaterThan(0);
            RuleFor(x=>x.Weight).GreaterThan(0);
            RuleFor(x => x.Description).NotEmpty().MinimumLength(15);
            RuleFor(x=>x.Name).NotEmpty().MinimumLength(3);
        }
    }
}
