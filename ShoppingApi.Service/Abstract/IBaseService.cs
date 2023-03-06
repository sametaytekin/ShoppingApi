using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Service.Abstract
{
    public interface IBaseService<Dto, Entity>
    {
        Task<Dto> GetByIdAsync(int id);

        Task<IEnumerable<Dto>> GetAllAsync();

        Task Insert(Dto insertModel);

        Task Update(int id,Dto updateModel);

        Task Delete(int id);

        Task<IEnumerable<Dto>> GetByFilter(Expression<Func<Entity, bool>> filterExpression);
    }
}
