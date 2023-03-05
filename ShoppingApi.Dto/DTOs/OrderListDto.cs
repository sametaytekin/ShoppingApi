using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Dto.DTOs
{
    public class OrderListDto:BaseModel
    {
        public string? Note { get; set; }

        public float Cost { get; set; }

        public DateTime Finished { get; set; }

        public DateTime CreatedBy { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }



    }
}
