using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Repository;
using Autofac;

namespace Ioc.Container
{
    public class AutofacModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterModule(new ApiHandiCrafts.Service.ModuleRegister());


            builder.RegisterModule(new ApiHandiCrafts.Repository.ModuleRegister());



            builder.RegisterModule(new ApiHandiCrafts.Contract.ModuleRegister());


            base.Load(builder);
        }
    }
}
