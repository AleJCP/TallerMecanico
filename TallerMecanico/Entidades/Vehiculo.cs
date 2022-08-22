using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    [Table("Vehiculo")]
    class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } //Unico
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public int IdCliente { get; set; }
        // Objeto que representa la clave externa.
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
