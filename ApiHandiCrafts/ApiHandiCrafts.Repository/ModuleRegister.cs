using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Repositories;
using ApiHandiCrafts.Contract.UnitofWork;
using ApiHandiCrafts.Repository.Repositories;
using Autofac;

namespace ApiHandiCrafts.Repository
{
    public class ModuleRegister : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(typeof(ModuleRegister).Assembly)
                .AsImplementedInterfaces()
                .AsSelf();

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerRequest();

            builder.RegisterType(typeof(UnitOfWork.UnitOfWork)).As(typeof(IUnitOfWorkAsync)).InstancePerRequest();

            builder.RegisterType(typeof(CustomerInformationRepository)).As(typeof(ICustomerInformationRepository)).InstancePerRequest();
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }
    }
}
