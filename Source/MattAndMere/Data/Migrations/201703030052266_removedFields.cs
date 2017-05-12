namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedFields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Email");
            DropColumn("dbo.Reservations", "Guests");
            DropColumn("dbo.Reservations", "ShuttleCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "ShuttleCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "Guests", c => c.String());
            AddColumn("dbo.Reservations", "Email", c => c.String());
        }
    }
}
