using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Dto.DTOs
{
    public class UserDto:BaseModel
    {
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
