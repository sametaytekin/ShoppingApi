using ShoppingApi.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Dto.DTOs
{
    public class ProductDto:BaseDto
    {
        public int Quantity { get; set; }

        public float Weight { get; set; }

        public string? Description { get; set; }

    }
}
