using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Service;
using ApiHandiCrafts.Service.Common;
using Autofac;

namespace ApiHandiCrafts.Service
{
    public class ModuleRegister : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ModuleRegister).Assembly)
                .AsImplementedInterfaces()
                .AsSelf();

            //builder.RegisterGeneric(typeof(EntityService<>)).InstancePerRequest();
            builder.RegisterGeneric(typeof(EntityService<>)).As(typeof(IEntityService<>)).InstancePerRequest();

            base.Load(builder);
        }
    }
}
