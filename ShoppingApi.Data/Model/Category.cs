using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Model
{
    public class Category:BaseModel
    {
        public string Type { get; set; }

        public int isActive { get; set; }
    }
}
