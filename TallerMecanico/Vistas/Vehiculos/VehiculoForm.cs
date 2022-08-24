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

namespace TallerMecanico.Vistas.Vehiculos
{
    public partial class VehiculoForm : Form
    {
        ICServicios cServicios = new CServicios();
        Cliente clienteSeleccionado = new Cliente();
        public VehiculoForm()
        {
            InitializeComponent();
            CargarTabla();
            gridView1.Columns.RemoveAt(gridView1.Columns.ToList().Count - 1);
        }

        private void btnAddVehiculo_Click(object sender, EventArgs e)
        {
            Form Dialog = new VehiculoDialog();
            Dialog.ShowDialog();
            CargarTabla();
        }

        public void CargarTabla()
        {
            //EN caso de que no haya un cliente seleccionado, se carga la lista normal
            //Si hay un cliente seleccioando quiere decir que esta en modo filtrado
            
            if(clienteSeleccionado.Id == 0)
            {
                bindingSourceVehiculo.DataSource = cServicios.ListarVehiculos();
                gridControlVehiculo.DataSource = bindingSourceVehiculo;
                labelTextShow.Text = $"Mostrando todos";
            }
            else
            {
                bindingSourceVehiculo.DataSource = cServicios.ListarVehiculosPorCliente(clienteSeleccionado);
                gridControlVehiculo.DataSource = bindingSourceVehiculo;
                labelTextShow.Text = $"Mostrando los vehiculos de {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
            }                        
        }

        private void btnEditVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = bindingSourceVehiculo.Current as Vehiculo;
            if(vehiculo != null)
            {
                Form Dialog = new VehiculoDialog(vehiculo, "Editar");
                Dialog.ShowDialog();
                CargarTabla();
            }           
        }

        private void btnDropVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSelected = bindingSourceVehiculo.Current as Vehiculo;
            if(vehiculoSelected != null)
            {
                if (MessageBox.Show($"Se eliminará el Vehiculo con el ID: {vehiculoSelected.Id}? Toda la informacion asociada al Vehiculo se eliminará", "Eliminar Vehiculo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (cServicios.DropVehiculo(vehiculoSelected))
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Logica de pasar la informacio de un cliente desde el model CedulaFiltroDialog
            CedulaFiltroDialog Dialog = new CedulaFiltroDialog();
            Dialog.ShowDialog();

            if(Dialog.DialogResult == DialogResult.OK)
            {
                clienteSeleccionado = Dialog.clienteS;
                CargarTabla();
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = new Cliente();
            CargarTabla();
            
        }
    }
}
