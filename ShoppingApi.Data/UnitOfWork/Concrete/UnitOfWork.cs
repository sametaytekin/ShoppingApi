using Microsoft.EntityFrameworkCore.Storage;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Context;
using ShoppingApi.Data.Model;
using ShoppingApi.Data.Repository.Concrete;
using ShoppingApi.Data.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.UnitOfWork.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        public readonly ShoppingDbContext dbContext;
        IDbContextTransaction transaction = null;


        public IGenericRepository<Product> ProductRepository { get; private set; }

        public IGenericRepository<Category> CategoryRepository { get; private set; }

        public IGenericRepository<OrderList> OrderListRepository {get; private set; }
        
        public UnitOfWork(ShoppingDbContext dbContext)
        {
            this.dbContext = dbContext;
            ProductRepository = new GenericRepository<Product>(dbContext);
            CategoryRepository = new GenericRepository<Category>(dbContext);
            OrderListRepository = new GenericRepository<OrderList>(dbContext);

            transaction=this.dbContext.Database.BeginTransaction();

        }

        public async Task CompleteAsync()
        {
            try
            {
                dbContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();

        }
    }
}
