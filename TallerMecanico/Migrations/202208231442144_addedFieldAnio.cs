namespace TallerMecanico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFieldAnio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehiculo", "Anio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehiculo", "Anio");
        }
    }
}
