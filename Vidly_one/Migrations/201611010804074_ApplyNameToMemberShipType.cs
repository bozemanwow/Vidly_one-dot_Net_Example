namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyNameToMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
