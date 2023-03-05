using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Data.UnitOfWork.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<OrderList> OrderListRepository { get; }

        Task CompleteAsync();
    }
}
