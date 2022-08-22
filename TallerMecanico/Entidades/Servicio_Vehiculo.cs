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
        public int IdVehiculo { get; set; }
        [ForeignKey("IdVehiculo")]
        public Vehiculo Vehiculo { get; set; }
        public int IdServicio { get; set; }
        [ForeignKey("IdServicio")]
        public Servicio Servicio { get; set; }
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }   
    }
}
