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
        public readonly IUnitOfWork _unitOfWork;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper):base(unitOfWork,mapper,repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        //Soft Delete
        public override async Task Delete(int id)
        {
            if(id < 0)
            {
                throw new InvalidOperationException("Id should be greater than 0(zero)");
            }

            var tempEntity = await _repository.GetByIdAsync(id);
            if(tempEntity == null)
            {
                throw new InvalidOperationException("Not Found");

            }
            tempEntity.isActive = false;
            await _unitOfWork.CompleteAsync();
        }

    }
}
