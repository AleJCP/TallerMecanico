using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Entidades;

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

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;

            if(trabajoDTO != null)
            {
                Trabajo trabajoSelected = new Trabajo();
                trabajoSelected.Id = trabajoDTO.Id;
                Form Dialog = new TrabajoDialog(trabajoSelected,"Editar");
                Dialog.ShowDialog();
                CargarTabla();
            }
        }

        private void btnDropCliente_Click(object sender, EventArgs e)
        {
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;
            Trabajo trabajoSelected = new Trabajo();
            trabajoSelected.Id = trabajoDTO.Id;

            if (trabajoDTO != null)
            {
                if (MessageBox.Show($"Se eliminará el Vehiculo con el ID: {trabajoSelected.Id}? Toda la informacion asociada al Trabajo se eliminará", "Eliminar Trabajo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    
                    if (cServicios.DropTrabajo(trabajoSelected))
                    {
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTabla();
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
