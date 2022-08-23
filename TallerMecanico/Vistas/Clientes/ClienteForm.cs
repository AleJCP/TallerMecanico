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

namespace TallerMecanico.Vistas.Clientes
{
    public partial class ClienteForm : Form
    {
        ICServicios cServicios = new CServicios();
        Cliente clienteSelected;
        string modo { get; set; }
        public ClienteForm()
        {
            InitializeComponent();
            CargarTabla();
        }
        public void CargarTabla()
        {
            bindingSourceCliente.DataSource = cServicios.ListarClientes();
            gridControlCliente.DataSource = bindingSourceCliente;
        }
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Form form = new ClienteDialog();
            form.ShowDialog();
            //Luego del proceso de agregar actualizamos la tabla
            CargarTabla();
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            clienteSelected = bindingSourceCliente.Current as Cliente;
            if(clienteSelected != null)
            {
                Form form = new ClienteDialog(clienteSelected, "Editar");
                form.ShowDialog();
                //Luego del proceso de agregar actualizamos la tabla
                CargarTabla();
            }
            
        }

        private void btnDropCliente_Click(object sender, EventArgs e)
        {
            clienteSelected = bindingSourceCliente.Current as Cliente;
            if(clienteSelected != null)
            {
                if (MessageBox.Show($"Se eliminará el Cliente con el ID: {clienteSelected.Id}? Toda la informacion asociada al Cliente se eliminará", "Eliminar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (cServicios.DropCliente(clienteSelected))
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
