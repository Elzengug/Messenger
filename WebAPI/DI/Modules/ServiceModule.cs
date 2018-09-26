using Autofac;
using BLL.Contracts;
using BLL.Services;
using System;

namespace WebAPI.DI.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientGroupService>().As<IClientGroupService>().InstancePerRequest();
            builder.RegisterType<ClientJobService>().As<IClientJobService>().InstancePerRequest();
            builder.RegisterType<ClientMessageService>().As<IClientMessageService>().InstancePerRequest();
            builder.RegisterType<ClientService>().As<IClientService>().InstancePerRequest();
            builder.RegisterType<GroupService>().As<IGroupService>().InstancePerRequest();
            builder.RegisterType<JobService>().As<IJobService>().InstancePerRequest();
            builder.RegisterType<MessageService>().As<IMessageService>().InstancePerRequest();
        }
    }
}