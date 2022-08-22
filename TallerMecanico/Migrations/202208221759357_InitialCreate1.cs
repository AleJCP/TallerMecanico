namespace TallerMecanico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "usuario");
            DropColumn("dbo.User", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "password", c => c.String());
            AddColumn("dbo.User", "usuario", c => c.String());
        }
    }
}
