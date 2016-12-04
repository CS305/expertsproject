namespace ExpertsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPostTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Body = c.String(),
                        UserID = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.String(nullable: false, maxLength: 128),
                        PostID = c.String(maxLength: 128),
                        Body = c.String(),
                        Username = c.String(),
                        DatePosted = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CommentID)
                //.ForeignKey("dbo.Posts", t => t.PostID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.PostID)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.String(nullable: false, maxLength: 128),
                        Subject = c.String(),
                        Body = c.String(),
                        ToEmail = c.String(),
                        FromEmail = c.String(),
                        DatePosted = c.DateTime(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.AspNetUsers", "PostID", c => c.String());
            AddColumn("dbo.AspNetUsers", "CommentID", c => c.String());
            //DropTable("dbo.Messages");
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        OriginalDate = c.DateTime(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToEmail = c.String(),
                        FromEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Posts", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Comments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropColumn("dbo.AspNetUsers", "CommentID");
            DropColumn("dbo.AspNetUsers", "PostID");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.MessageModels");
        }
    }
}
