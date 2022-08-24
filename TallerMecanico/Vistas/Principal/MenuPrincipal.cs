using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico.Vistas.Principal
{
    public partial class MenuPrincipal : Form
    {
        ICServicios cServicios = new CServicios();
        public MenuPrincipal()
        {
            InitializeComponent();
            EmpTotales.Text = cServicios.ContarClientes().ToString();
            SerTotales.Text = cServicios.ContarServicios().ToString();
            DateTime date = DateTime.Today;
            NomPorMes.Text = cServicios.ContarTrabajosPorFecha(date).ToString();
            //Faltan los servicios realizados
            MesActual.Text = $"Hoy, {DateTime.Now.ToString("M")} de {DateTime.Now.ToString("yyyy")} ";
        }
    }
}
