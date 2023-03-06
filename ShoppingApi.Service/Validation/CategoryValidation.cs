using FluentValidation;
using ShoppingApi.Dto.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Validation
{
    public class CategoryValidation : AbstractValidator<CategoryDto>
    {
        public CategoryValidation()
        {
            RuleFor(x=>x.Name).NotEmpty().MinimumLength(3);
            RuleFor(x=>x.Type).NotEmpty().MinimumLength(3);
        }

    }
}
