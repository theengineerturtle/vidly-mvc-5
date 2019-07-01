namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_membershiptype_name2 : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET NAME='Monthly' where ID=2");
            Sql("Update MembershipTypes SET NAME='3 Months' where ID=3");
            Sql("Update MembershipTypes SET NAME='Annual' where ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
