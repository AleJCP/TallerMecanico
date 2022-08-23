namespace TallerMecanico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDiagram_Added_Trabajo_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trabajo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comentarios = c.String(),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Servicio_Vehiculo", "IdTrabajo", c => c.Int(nullable: false));
            CreateIndex("dbo.Servicio_Vehiculo", "IdTrabajo");
            AddForeignKey("dbo.Servicio_Vehiculo", "IdTrabajo", "dbo.Trabajo", "Id", cascadeDelete: true);
            DropColumn("dbo.Servicio_Vehiculo", "Comentarios");
            DropColumn("dbo.Servicio_Vehiculo", "Fecha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servicio_Vehiculo", "Fecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.Servicio_Vehiculo", "Comentarios", c => c.String());
            DropForeignKey("dbo.Servicio_Vehiculo", "IdTrabajo", "dbo.Trabajo");
            DropIndex("dbo.Servicio_Vehiculo", new[] { "IdTrabajo" });
            DropColumn("dbo.Servicio_Vehiculo", "IdTrabajo");
            DropTable("dbo.Trabajo");
        }
    }
}
