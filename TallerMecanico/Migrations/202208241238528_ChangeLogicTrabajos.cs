namespace TallerMecanico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLogicTrabajos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Servicio_Vehiculo", "IdVehiculo", "dbo.Vehiculo");
            DropIndex("dbo.Servicio_Vehiculo", new[] { "IdVehiculo" });
            AddColumn("dbo.Trabajo", "IdVehiculo", c => c.Int(nullable: false));
            CreateIndex("dbo.Trabajo", "IdVehiculo");
            AddForeignKey("dbo.Trabajo", "IdVehiculo", "dbo.Vehiculo", "Id", cascadeDelete: true);
            DropColumn("dbo.Servicio_Vehiculo", "IdVehiculo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servicio_Vehiculo", "IdVehiculo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Trabajo", "IdVehiculo", "dbo.Vehiculo");
            DropIndex("dbo.Trabajo", new[] { "IdVehiculo" });
            DropColumn("dbo.Trabajo", "IdVehiculo");
            CreateIndex("dbo.Servicio_Vehiculo", "IdVehiculo");
            AddForeignKey("dbo.Servicio_Vehiculo", "IdVehiculo", "dbo.Vehiculo", "Id", cascadeDelete: true);
        }
    }
}
