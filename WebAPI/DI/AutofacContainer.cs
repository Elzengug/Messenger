using Autofac;
using DAL.Contracts.Context;
using DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using WebAPI.DI.Modules;

namespace WebAPI.DI
{
    public class AutofacContainer
    {
        public Autofac.IContainer CreateContainer(Assembly webApiAssembly)
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterModule(new WebApiModule(webApiAssembly));
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());

            return builder.Build();
        }
    }
}