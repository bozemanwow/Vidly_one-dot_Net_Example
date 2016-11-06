namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Type = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "MemberShipType_Type");
            DropColumn("dbo.Customers", "MemberShipType_SignUpFee");
            DropColumn("dbo.Customers", "MemberShipType_DurationInMonths");
            DropColumn("dbo.Customers", "MemberShipType_DiscountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipType_DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemberShipType_DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemberShipType_SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.Customers", "MemberShipType_Type", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.MemberShipTypes");
        }
    }
}
