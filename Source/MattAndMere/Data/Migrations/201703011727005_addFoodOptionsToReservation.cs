namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFoodOptionsToReservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "SalmonCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "PorkCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "RavioliCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "Message", c => c.String());
            AlterColumn("dbo.Reservations", "Name", c => c.String());
            AlterColumn("dbo.Reservations", "Email", c => c.String());
            AlterColumn("dbo.Reservations", "Guests", c => c.String());
            AlterColumn("dbo.Reservations", "Hotel", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "Hotel", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "Guests", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Reservations", "Message");
            DropColumn("dbo.Reservations", "RavioliCount");
            DropColumn("dbo.Reservations", "PorkCount");
            DropColumn("dbo.Reservations", "SalmonCount");
        }
    }
}
