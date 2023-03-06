using AutoMapper;
using ShoppingApi.Base.Model;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.UnitOfWork.Abstract;
using ShoppingApi.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Concrete
{
    public class BaseService<Dto, Entity> : IBaseService<Dto, Entity> where Entity : BaseModel
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Entity> genericRepository;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Entity> genericRepository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async virtual Task Delete(int id)
        {
            if (id < 0)
            {
                throw new InvalidOperationException("Id should be greater than 0(zero)");
            }
            
            var tempEntity= await genericRepository.GetByIdAsync(id);
            
            if(tempEntity == null)
            {
                throw new InvalidOperationException("Not Found");
            }
            genericRepository.Delete(tempEntity);
            await unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<Dto>> GetAllAsync()
        {
            var entityAll= await genericRepository.GetAll();

            var result = mapper.Map<IEnumerable<Entity>, IEnumerable<Dto>>(entityAll);

            return result;

        }

        public async Task<IEnumerable<Dto>> GetByFilter(Expression<Func<Entity, bool>> filterExpression)
        {
            var filtered = await genericRepository.GetByFilter(filterExpression);
            var result =mapper.Map<IEnumerable<Entity>, IEnumerable<Dto>>(filtered);
            return result;
        }

        public async Task<Dto> GetByIdAsync(int id)
        {
            var entity= await genericRepository.GetByIdAsync(id);
            var result =mapper.Map<Entity,Dto>(entity);
            return result;
        }

        public async Task Insert(Dto insertModel)
        {
            var entity = mapper.Map<Dto,Entity>(insertModel);
            await genericRepository.Create(entity);
            await unitOfWork.CompleteAsync();
        }

        public async Task Update(int id, Dto updateModel)
        {
            if (id < 0)
            {
                throw new InvalidOperationException("Id should be greater than 0(zero)");
            }
            
            var tempEntity = await genericRepository.GetByIdAsync(id);
            
            if(tempEntity == null)
            {
                throw new InvalidOperationException("Not Found");
            }

            var entity = mapper.Map(updateModel,tempEntity);
            genericRepository.Update(entity);
            await unitOfWork.CompleteAsync();
        }
    }
}
