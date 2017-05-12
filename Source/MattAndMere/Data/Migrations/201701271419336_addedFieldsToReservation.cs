namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFieldsToReservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Guests", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Shuttle", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reservations", "ShuttleCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "Hotel", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "Names");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Names", c => c.String());
            DropColumn("dbo.Reservations", "DateCreated");
            DropColumn("dbo.Reservations", "Hotel");
            DropColumn("dbo.Reservations", "ShuttleCount");
            DropColumn("dbo.Reservations", "Shuttle");
            DropColumn("dbo.Reservations", "Guests");
            DropColumn("dbo.Reservations", "Email");
            DropColumn("dbo.Reservations", "Name");
        }
    }
}
