namespace GoatHuntAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHuntNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hunts", "HuntNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hunts", "HuntNumber");
        }
    }
}
