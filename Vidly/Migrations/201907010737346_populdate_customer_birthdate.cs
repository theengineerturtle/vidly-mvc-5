namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populdate_customer_birthdate : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET Birthdate='01.01.1989' where ID=1");
            Sql("Update Customers SET Birthdate='01.01.1985' where ID=3");

        }

        public override void Down()
        {
        }
    }
}
