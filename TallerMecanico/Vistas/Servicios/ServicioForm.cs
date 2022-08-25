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

namespace TallerMecanico.Vistas.Servicios
{
    public partial class ServicioForm : Form
    {
        ICServicios cServicios = new CServicios();
        Servicio servicioSelected = new Servicio();
        public ServicioForm()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void btnAddServicio_Click(object sender, EventArgs e)
        {
            Form Dialog = new ServicioDialog(null, "Guardar");
            Dialog.ShowDialog();
            
            CargarTabla();
        }

        public void CargarTabla()
        {
            bindingSourceServicio.DataSource = cServicios.ListarServicios();
            gridControlServicio.DataSource = bindingSourceServicio;
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            servicioSelected = bindingSourceServicio.Current as Servicio;
            if(servicioSelected != null)
            {
                Form Dialog = new ServicioDialog(servicioSelected, "Editar");
                Dialog.ShowDialog();
                
                CargarTabla();
            }            
        }

        private void btnDropCliente_Click(object sender, EventArgs e)
        {

            servicioSelected = bindingSourceServicio.Current as Servicio;
            if(servicioSelected != null)
            {
                if (MessageBox.Show($"Se eliminará el Servicio con el ID: {servicioSelected.Id}? Toda la informacion asociada al Servicio se eliminará", "Eliminar Servicio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (cServicios.DropServicio(servicioSelected))
                    {
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
