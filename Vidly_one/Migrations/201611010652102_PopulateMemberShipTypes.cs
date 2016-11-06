namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Type) VALUES (1,0,0,0  , 3)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Type) VALUES (2,30,1,10, 3)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Type) VALUES (3,90,3,15, 3)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Type) VALUES (4,20,4,20, 3)");



        }

        public override void Down()
        {
        }
    }
}
