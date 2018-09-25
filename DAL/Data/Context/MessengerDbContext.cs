using DAL.Contracts.Context;
using DAL.Models.Authorization;
using DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class MessengerDbContext : DbContext, IDbContext
    {
        // public const string ConnectionString =
        //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public MessengerDbContext() : base("DefaultConnection")
        {

        }
        public static MessengerDbContext Create()
        {
            return new MessengerDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientGroup>().HasKey(k => new { k.ClientId, k.GroupId });
            modelBuilder.Entity<ClientMessage>().HasKey(k => new { k.ClientId, k.MessageId });
            modelBuilder.Entity<ClientJob>().HasKey(k => new { k.ClientId, k.JobId});
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientGroup> ClientGroups { get; set; }
        public DbSet<ClientMessage> ClientMessages { get; set; }
        public DbSet<ClientJob> ClientJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
