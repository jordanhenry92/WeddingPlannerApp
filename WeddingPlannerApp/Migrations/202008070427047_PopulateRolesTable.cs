namespace WeddingPlannerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRolesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Roles (Id, Name) VALUES (1, 'Groom')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (2, 'Bride')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (3, 'Best Man')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (4, 'Maid of Honor')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (5, 'Groomsman')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (6, 'Bridesmaid')");
            Sql("INSERT INTO Roles (Id, Name) VALUES (7, 'Guest')");
        }
        
        public override void Down()
        {
        }
    }
}
