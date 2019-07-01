namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_example_movies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (NAME,GENREID,RELEASEDATE,DATEADD,NUMBERINSTOCK) VALUES('Hangover',1,'10.07.2009','01.06.2019',10)");

        }
        
        public override void Down()
        {
        }
    }
}
