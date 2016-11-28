namespace ExpertsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "expertise", c => c.String());
            AddColumn("dbo.AspNetUsers", "expertise2", c => c.String());
            AddColumn("dbo.AspNetUsers", "expertise3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "expertise3");
            DropColumn("dbo.AspNetUsers", "expertise2");
            DropColumn("dbo.AspNetUsers", "expertise");
        }
    }
}
