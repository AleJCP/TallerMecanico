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
    partial class CedulaFiltroDialog : Form
    {        
        public Cliente clienteS = new Cliente();
        ICServicios cServicios = new CServicios();
        public CedulaFiltroDialog()
        {
            InitializeComponent();
        }

        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = textCedula.Text;
            cliente = cServicios.GetCliente(cliente);

            if (cliente == null || cliente.Id == 0)
            {
                MessageBox.Show("Ese Cliente no está registrado");
            }
            else
            {                
                //Seteamos el objeto
                clienteS = cliente;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
