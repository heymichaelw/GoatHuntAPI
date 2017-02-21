namespace GoatHuntAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class IncorporateData : DbMigration
    {
        public override void Up()
        {
            var systemPath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\Data.csv";
            var openFile = File.ReadAllLines(systemPath);
            using (var db = new ApplicationContext())
            {
                foreach (string row in openFile)
                {
                    var data = row.Split(',');
                    Hunt newHunt = new Hunt
                    {
                        HuntNumber = int.Parse(data[7]),
                        Name = data[0],
                        Type = data[1],
                        Permits = int.Parse(data[2]),
                        HuntersAfield = int.Parse(data[3]),
                        Harvest = int.Parse(data[4]),
                        AverageDays = double.Parse(data[5]),
                        PercentSuccess = double.Parse(data[6])
                    };
                    db.Hunts.Add(newHunt);
                }
                db.SaveChanges();
            }
            throw new Exception(systemPath);
        }
        
        public override void Down()
        {
        }
    }
}
