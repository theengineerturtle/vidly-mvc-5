namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class POPULATEMOVIES : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (NAME,GENREID,RELEASEDATE,DATEADD,NUMBERINSTOCK) VALUES('Toy Story',3           ,'19.04.1996',      '01.06.2019',10)");
          
        }
        
        public override void Down()
        {
        }
    }
}
