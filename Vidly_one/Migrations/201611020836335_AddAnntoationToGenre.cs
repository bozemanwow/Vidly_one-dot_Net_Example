namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnntoationToGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
