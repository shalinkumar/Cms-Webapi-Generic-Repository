using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Ioc.Container;

namespace ApiHandiCrafts
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();         
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);                    
            builder.RegisterModule(new AutofacModule());        
            var container = builder.Build();
            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);           
        }
    }
}