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
    public class OrderListService:BaseService<OrderListDto,OrderList>,IOrderListService
    {
        public readonly IGenericRepository<OrderList> repository;
        public OrderListService(IGenericRepository<OrderList> repository,IMapper mapper, IUnitOfWork unitOfWork):base(unitOfWork,mapper,repository)
        {
            this.repository = repository;
        }
    }
}
