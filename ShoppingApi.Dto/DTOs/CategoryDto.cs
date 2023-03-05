using ShoppingApi.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Dto.DTOs
{
    public class CategoryDto:BaseDto
    {
        [Required]
        public string? Type { get; set; }

        public int isActive { get; set; }
    }
}
