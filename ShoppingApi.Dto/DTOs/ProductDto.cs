using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Dto.DTOs
{
    public class ProductDto:BaseModel
    {
        public int Quantity { get; set; }

        public float Weight { get; set; }

        public string? Description { get; set; }

        public int OrderListId { get; set; }
    }
}
