namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mealChoice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "MealChoice", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "SalmonCount");
            DropColumn("dbo.Reservations", "PorkCount");
            DropColumn("dbo.Reservations", "RavioliCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "RavioliCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "PorkCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "SalmonCount", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "MealChoice");
        }
    }
}
