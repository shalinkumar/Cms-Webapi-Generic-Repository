using System.Data.Entity;
using ApiHandiCrafts.Contract.Models;
using Autofac;

namespace ApiHandiCrafts.Contract
{
    public class ModuleRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<AuditableEntity>().As<IAuditableEntity>().InstancePerRequest();

            builder.Register(c => new HandiCraftsContext()).As<DbContext>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(ModuleRegister).Assembly).AsImplementedInterfaces().AsSelf();

            //builder.RegisterType<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }
    }
}
