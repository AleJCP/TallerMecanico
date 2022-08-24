using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    [Table("Servicio_Vehiculo")]
    class Servicio_Vehiculo
    {
        public int Id { get; set; }
        public int IdTrabajo { get; set; }
        [ForeignKey("IdTrabajo")]
        public Trabajo Trabajo { get; set; }        
        public int IdServicio { get; set; }
        [ForeignKey("IdServicio")]
        public Servicio Servicio { get; set; }   
    }

    //class Trabajo
    //{
    //    //Articulos - Salidas
    //    //articulos-salidas        
    //    public int IdVehiculo { get; set; }
    //    public string Placa { get; set; }
    //    public string Marca { get; set; }
    //    public string Modelo { get; set; }
    //    public string Color { get; set; }
    //    public string Anio { get; set; }                
    //    public string Comentarios { get; set; }
    //    public DateTime Fecha { get; set; }
    //}
}
