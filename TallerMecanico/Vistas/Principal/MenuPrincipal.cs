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
            //Faltan los servicios realizados
        }
    }
}
