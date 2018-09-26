using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using Module = Autofac.Module;

namespace WebAPI.DI.Modules
{
    public class WebApiModule : Module
    {
        private readonly Assembly _webApiAssembly;
        public WebApiModule(Assembly webApiAssembly)
        {
            _webApiAssembly = webApiAssembly;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(_webApiAssembly);
        }
    }
}