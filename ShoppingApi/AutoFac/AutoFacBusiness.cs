using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using AutoMapper;
using ShoppingApi.Data.Abstract;
using ShoppingApi.Data.Model;
using ShoppingApi.Data.Repository.Concrete;
using ShoppingApi.Data.UnitOfWork.Abstract;
using ShoppingApi.Data.UnitOfWork.Concrete;
using ShoppingApi.Service.Abstract;
using ShoppingApi.Service.Concrete;
using ShoppingApi.Service.Mapper;

namespace ShoppingApi.AutoFac
{
    public class AutoFacBusiness:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<GenericRepository<Product>>().As<IGenericRepository<Product>>().InstancePerLifetimeScope();

            builder.RegisterType<GenericRepository<Category>>().As<IGenericRepository<Category>>().InstancePerLifetimeScope();

            builder.RegisterType<GenericRepository<OrderList>>().As<IGenericRepository<OrderList>>().InstancePerLifetimeScope();


            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<OrderListService>().As<IOrderListService>().InstancePerLifetimeScope();

            var mapper = new MapperConfiguration(conf 
                => conf.AddProfile(new MappingProfile()) );
            var profile = mapper.CreateMapper();
            builder.Register(context=>profile).SingleInstance();

        }
    }
}
