namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWillAttend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "WillAttend", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "WillAttend");
        }
    }
}
