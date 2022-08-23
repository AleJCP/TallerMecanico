using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico.Vistas.Trabajos
{
    public partial class TrabajoForm : Form
    {
        ICServicios cServicios = new CServicios();
        public TrabajoForm()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void btnAddTrabajo_Click(object sender, EventArgs e)
        {
            Form Dialog = new TrabajoDialog();
            Dialog.ShowDialog();
            CargarTabla();
        }

        public void CargarTabla()
        {
            bindingSourceTrabajos.DataSource = cServicios.ListarTrabajosDTO();
            gridControlTrabajos.DataSource = bindingSourceTrabajos;
        }
    }
}
