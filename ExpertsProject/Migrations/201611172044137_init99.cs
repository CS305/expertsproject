namespace ExpertsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init99 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "isDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "isDeleted");
        }
    }
}
