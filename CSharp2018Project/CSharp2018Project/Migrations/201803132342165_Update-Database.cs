namespace CSharp2018Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drinks", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drinks", "Notes");
        }
    }
}
