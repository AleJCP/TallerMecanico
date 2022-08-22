namespace TallerMecanico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Apellido = c.String(),
                    Cedula = c.String(),
                    Telefono = c.String(),
                    Direccion = c.String(),
                })
                .PrimaryKey(t => t.Id);                

            CreateTable(
                "dbo.Servicio_Vehiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdVehiculo = c.Int(nullable: false),
                        IdServicio = c.Int(nullable: false),
                        Comentarios = c.String(),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicio", t => t.IdServicio, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.IdVehiculo, cascadeDelete: true)
                .Index(t => t.IdVehiculo)
                .Index(t => t.IdServicio);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Color = c.String(),
                        Tipo = c.String(),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        usuario = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servicio_Vehiculo", "IdVehiculo", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Servicio_Vehiculo", "IdServicio", "dbo.Servicio");
            DropIndex("dbo.Vehiculo", new[] { "IdCliente" });
            DropIndex("dbo.Servicio_Vehiculo", new[] { "IdServicio" });
            DropIndex("dbo.Servicio_Vehiculo", new[] { "IdVehiculo" });
            DropTable("dbo.User");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Servicio");
            DropTable("dbo.Servicio_Vehiculo");
            DropTable("dbo.Cliente");
        }
    }
}
