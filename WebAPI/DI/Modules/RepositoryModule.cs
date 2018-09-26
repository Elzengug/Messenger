using Autofac;
using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Data.Context;
using DAL.Data.Repositories;

namespace WebAPI.DI.Modules
{
    internal class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessengerDbContext>().As<IDbContext>().InstancePerRequest();

            builder.RegisterType<ClientGroupRepository>().As<IClientGroupRepository>().InstancePerRequest();
            builder.RegisterType<ClientJobRepository>().As<IClientJobRepository>().InstancePerRequest();
            builder.RegisterType<ClientMessageRepository>().As<IClientMessageRepository>().InstancePerRequest();
            builder.RegisterType<ClientRepository>().As<IClientRepository>().InstancePerRequest();
            builder.RegisterType<GroupRepository>().As<IGroupRepository>().InstancePerRequest();
            builder.RegisterType<JobRepository>().As<IJobRepository>().InstancePerRequest();
            builder.RegisterType<MessageRepository>().As<IMessageRepository>().InstancePerRequest();
        }
    }
}