namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_movie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (NAME,GENREID,RELEASEDATE,DATEADD,NUMBERINSTOCK) VALUES('The Terminator',2      ,'01.1.2019',      '01.06.2019',10)");

        }
        
        public override void Down()
        {
        }
    }
}
