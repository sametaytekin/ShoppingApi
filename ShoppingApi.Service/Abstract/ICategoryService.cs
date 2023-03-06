using ShoppingApi.Data.Model;
using ShoppingApi.Dto.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Abstract
{
    public interface ICategoryService:IBaseService<CategoryDto,Category>
    {
    }
}
