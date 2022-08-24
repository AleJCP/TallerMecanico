using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    [Table("Trabajo")]
    class Trabajo
    {
        public int Id { get; set; }
        public int IdVehiculo { get; set; }
        [ForeignKey("IdVehiculo")]
        public Vehiculo Vehiculo { get; set; }
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }
    }

    class TrabajoDTO
    {
        public int Id { get; set; }
        public string DatosCliente { get; set; }
        public string DatosVehiculo { get; set; }       
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }
    }
}
