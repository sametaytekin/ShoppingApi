using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShoppingApi.Data.Model;
using ShoppingApi.Dto.DTOs;

namespace ShoppingApi.Service.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto,Category>();

            CreateMap<OrderList, OrderListDto>();
            CreateMap<OrderListDto, OrderList>();

            CreateMap<UserDto,User>();


        }
    }
}
