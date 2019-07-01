namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_genretable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Name) values('Action')");
            Sql("INSERT INTO GENRES (Name) values('Family') ");
            Sql("INSERT INTO GENRES (Name) values('Romance') ");
        }
        
        public override void Down()
        {
        }
    }
}
