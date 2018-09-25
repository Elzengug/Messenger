namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientGroups",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.GroupId })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientJobs",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.JobId })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                        DateComplete = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.ClientMessages",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        MessageId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => new { t.ClientId, t.MessageId })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Messages", t => t.MessageId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.MessageId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Messages", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.ClientMessages", "MessageId", "dbo.Messages");
            DropForeignKey("dbo.ClientMessages", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientJobs", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.ClientJobs", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientGroups", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientMessages", new[] { "MessageId" });
            DropIndex("dbo.ClientMessages", new[] { "ClientId" });
            DropIndex("dbo.Messages", new[] { "JobId" });
            DropIndex("dbo.ClientJobs", new[] { "JobId" });
            DropIndex("dbo.ClientJobs", new[] { "ClientId" });
            DropIndex("dbo.ClientGroups", new[] { "GroupId" });
            DropIndex("dbo.ClientGroups", new[] { "ClientId" });
            DropTable("dbo.Groups");
            DropTable("dbo.ClientMessages");
            DropTable("dbo.Messages");
            DropTable("dbo.Jobs");
            DropTable("dbo.ClientJobs");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientGroups");
        }
    }
}
