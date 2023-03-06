using AutoMapper;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Model;
using ShoppingApi.Data.UnitOfWork.Abstract;
using ShoppingApi.Dto.DTOs;
using ShoppingApi.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Concrete
{
    public class CategoryService:BaseService<CategoryDto,Category>,ICategoryService
    {
        public readonly IGenericRepository<Category> _repository;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper):base(unitOfWork,mapper,repository)
        {
            _repository = repository;
        }


    }
}
