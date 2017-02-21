namespace GoatHuntAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hunts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Permits = c.Int(nullable: false),
                        HuntersAfield = c.Int(nullable: false),
                        Harvest = c.Int(nullable: false),
                        AverageDays = c.Double(nullable: false),
                        PercentSuccess = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hunts");
        }
    }
}
