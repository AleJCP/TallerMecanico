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
    partial class ClienteDialog : Form
    {
        ICServicios cServicios = new CServicios();
        int IDCliente { get; set; }
        string modo { get; set; }

        public ClienteDialog(Cliente clienteAEditar = null, string modo = "Guardar")
        {
            InitializeComponent();            
            this.modo = modo;
            if (modo.Equals("Editar"))
            {
                IDCliente = clienteAEditar.Id;
                textNombre.Text = clienteAEditar.Nombre;
                textApellido.Text = clienteAEditar.Apellido;
                textCedula.Text = clienteAEditar.Cedula;
                textTelefono.Text = clienteAEditar.Telefono;
                textDireccion.Text = clienteAEditar.Direccion;
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Objeto Cliente
            Cliente cliente = new Cliente();
            cliente.Id = IDCliente;
            cliente.Nombre = textNombre.Text;
            cliente.Apellido = textApellido.Text;
            cliente.Cedula = textCedula.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.Direccion = textDireccion.Text;            
            //Validacion de CAMPOS
            if (String.IsNullOrEmpty(cliente.Nombre) || String.IsNullOrEmpty(cliente.Apellido) ||
                String.IsNullOrEmpty(cliente.Cedula) || String.IsNullOrEmpty(cliente.Telefono) ||
                String.IsNullOrEmpty(cliente.Direccion))
            {
                MessageBox.Show($"No debes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Validaciones con campos unicos en la base de datos
                if (!cServicios.IsCedulaValid(cliente))
                {
                    MessageBox.Show($"Ya existe esa Cédula en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!cServicios.IsTelefonoValid(cliente))
                {
                    MessageBox.Show($"Ya existe ese Teléfono en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (modo.Equals("Guardar"))
                    {
                        if (cServicios.AddCliente(cliente))
                        {
                            this.Dispose();
                            MessageBox.Show($"Proceso Ejecutado con éxito", "Cliente Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (cServicios.EditCliente(cliente))
                        {
                            this.Dispose();
                            MessageBox.Show($"Proceso Ejecutado con éxito", "Cliente Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
