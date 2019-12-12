namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitNewsApp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedDate = c.DateTime(storeType: "date"),
                        DeletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(nullable: false, maxLength: 100),
                        NewsDescription = c.String(nullable: false, maxLength: 200),
                        NewsBody = c.String(nullable: false, unicode: false, storeType: "text"),
                        NewsImage = c.String(nullable: false, maxLength: 50),
                        IsApproved = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        IsSlider = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedDate = c.DateTime(storeType: "date"),
                        DeletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false, maxLength: 500),
                        UserId = c.Int(nullable: false),
                        NewsId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedDate = c.DateTime(storeType: "date"),
                        DeletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 15),
                        Role = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedDate = c.DateTime(storeType: "date"),
                        DeletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        TagName = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedDate = c.DateTime(storeType: "date"),
                        DeletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.Tag_News",
                c => new
                    {
                        NewsId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NewsId, t.TagId })
                .ForeignKey("dbo.Tags", t => t.NewsId, cascadeDelete: true)
                .ForeignKey("dbo.News", t => t.TagId, cascadeDelete: true)
                .Index(t => t.NewsId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tag_News", "TagId", "dbo.News");
            DropForeignKey("dbo.Tag_News", "NewsId", "dbo.Tags");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Tag_News", new[] { "TagId" });
            DropIndex("dbo.Tag_News", new[] { "NewsId" });
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropTable("dbo.Tag_News");
            DropTable("dbo.Tags");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
