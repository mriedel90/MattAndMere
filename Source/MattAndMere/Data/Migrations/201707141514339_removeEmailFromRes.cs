namespace MattAndMere.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeEmailFromRes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Email", c => c.String());
        }
    }
}
