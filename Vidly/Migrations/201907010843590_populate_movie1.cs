namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_movie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (NAME,GENREID,RELEASEDATE,DATEADD,NUMBERINSTOCK) VALUES('Titanic',4             ,'1.10.1997',        '01.06.2019',10)");

        }

        public override void Down()
        {
        }
    }
}
