//using System.Web.Mvc;
using System.Web.Http;

//using Autofac.Integration.Mvc;


namespace ApiHandiCrafts
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {                      
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            AutofacConfig.ConfigureContainer();
            GlobalConfiguration.Configuration.EnsureInitialized();


            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
}
