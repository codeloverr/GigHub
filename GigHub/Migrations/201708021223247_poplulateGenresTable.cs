namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class poplulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) Values(1,'Jazz')");
            Sql("INSERT INTO GENRES (Id, Name) Values(2,'Blues')");
            Sql("INSERT INTO GENRES (Id, Name) Values(3,'Rock')");
            Sql("INSERT INTO GENRES (Id, Name) Values(4,'Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}
