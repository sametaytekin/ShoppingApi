using AutoMapper;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Model;
using ShoppingApi.Data.UnitOfWork.Abstract;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Concrete
{
    public class ProductService :BaseService<ProductDto,Product>,IProductService
    {
        public readonly IGenericRepository<Product> genericRepository;

        public ProductService(IGenericRepository<Product> genericRepository,IUnitOfWork unitOfWork,IMapper mapper):base(unitOfWork,mapper,genericRepository)
        {
            this.genericRepository = genericRepository;
        }


    }
}
