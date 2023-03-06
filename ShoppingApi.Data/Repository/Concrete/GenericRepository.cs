using Microsoft.EntityFrameworkCore;
using ShoppingApi.Base.Model;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.Repository.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity: BaseModel
    {
        private DbSet<TEntity> entities;
        public ShoppingDbContext _context;

        public GenericRepository( ShoppingDbContext context)
        {
            _context = context;
            this.entities = _context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
             await entities.AddAsync(entity);   
        }

        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            entities.Update(entity);
        }

        public async Task<IEnumerable<TEntity>> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
           return await entities.Where(filter).ToListAsync();
        }
    }
}
