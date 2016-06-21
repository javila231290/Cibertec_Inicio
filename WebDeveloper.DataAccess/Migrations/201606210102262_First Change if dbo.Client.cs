namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChangeifdboClient : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Client", "LastName", "Apellidos");
        }
    }
}
