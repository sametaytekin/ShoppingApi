using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Model
{
    public class User:BaseModel
    {
        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? RefreshToken { get; set; }

        public string? RefreshTokenExpire { get; set; }

        public int RoleId { get; set; }

        public ICollection<OrderList> OrderList { get; set; }

    }
}
