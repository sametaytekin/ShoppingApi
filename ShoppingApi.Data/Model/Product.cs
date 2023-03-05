using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Model
{
    public class Product:BaseModel
    {
        public int Quantity { get; set; }

        public float Weight { get; set; }

        public string? Description { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public int OrderListId { get; set; }

        public OrderList Order { get; set; }

    }
}
