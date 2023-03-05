using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Model
{
    public class OrderList:BaseModel
    {

        public DateTime CreatedBy { get; set; }

        public DateTime Finished { get; set; }

        public float Cost { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Product> Products { get; set; }

        public string? Note { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
