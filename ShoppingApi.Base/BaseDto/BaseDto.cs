using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ShoppingApi.Base.BaseDto
{
    public class BaseDto
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string? Name { get; set; }
    }
}
