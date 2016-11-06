namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnteriesToGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres ( Id,Name) VALUES (1,'Horrow')");
            Sql("INSERT INTO Genres ( Id,Name) VALUES (2,'Comdeic')");
            Sql("INSERT INTO Genres ( Id,Name) VALUES (3,'Actionio')");
            Sql("INSERT INTO Genres ( Id,Name) VALUES (4,'Cutys')");


        }

        public override void Down()
        {
        }
    }
}
