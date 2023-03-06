using ShoppingApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : BaseModel
    {
        //Get
        Task<IEnumerable<TEntity>> GetAll();
        //GetById
        Task<TEntity> GetByIdAsync(int id);
        //Create
        Task Create(TEntity entity);
        //Update
        void Update(TEntity entity);
        //Delete
        void Delete(TEntity entity);

        Task<IEnumerable<TEntity>> GetByFilter(Expression<Func<TEntity, bool>> filter);


    }
}
