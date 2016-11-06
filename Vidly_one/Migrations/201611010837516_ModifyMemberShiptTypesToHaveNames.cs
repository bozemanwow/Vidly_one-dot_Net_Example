namespace Vidly_one.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMemberShiptTypesToHaveNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'Free' WHERE Id = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'tri' WHERE Id = 2");
            Sql("UPDATE MemberShipTypes SET Name = 'qaurt' WHERE Id = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'twothirds' WHERE Id = 4");
         
        }
        
        public override void Down()
        {
        }
    }
}
