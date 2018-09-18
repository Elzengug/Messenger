using DAL.Contracts.Context;
using DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class MessengerDbContext: DbContext, IDbContext
    {
        public const string ConnectionString =
          @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public MessengerDbContext() : base(ConnectionString)
        {

        }
        public static MessengerDbContext Create()
        {
            return new MessengerDbContext();
        }

        public DbSet<Message> Messages;
        public DbSet<Client> Clients;
        public DbSet<ClientGroup> ClientGroups;
        public DbSet<ClientMessage> ClientMessages;
        public DbSet<ClientJob> ClientJobs;
        public DbSet<Job> Jobs;
        public DbSet<Group> Groups;
    }
}
