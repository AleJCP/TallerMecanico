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
    partial class VehiculoDialog : Form
    {
        ICServicios cServicios = new CServicios();
        int IDVehiculo { get; set; }        
        //Cliente de la transaccion para agregar el vehiculo
        Cliente clienteS = new Cliente();
        string modo { get; set; }

        public VehiculoDialog(Vehiculo vehiculo = null, string modo = "Guardar")
        {
            InitializeComponent();
            this.modo = modo;
            //Seteo
            if(vehiculo != null)
            {
                //Quitmaos el control de controlar el cliente
                textCedula.Enabled = false;
                btnBuscarCedula.Enabled = false;
                btnGuardar.Enabled = true;
                //Seteamos la info del vehiculo
                IDVehiculo = vehiculo.Id;
                txtPlaca.Text = vehiculo.Placa;
                textMarca.Text = vehiculo.Marca;
                textModelo.Text = vehiculo.Modelo;
                textColor.Text = vehiculo.Color;
                textTipo.Text = vehiculo.Tipo;
                textAnio.Text = vehiculo.Anio;
                //Buscamos la info del cliente y la setamos               
                Cliente cliente = cServicios.GetCliente(new Cliente() { Id = vehiculo.IdCliente });
                labelNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                textCedula.Text = cliente.Cedula;
            }
        }

        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            //Buscarmos en la BD si existe la cedula, en ese caso seteamos y activamos el control para agregar el vehiculo
            //En caso contrario no hacemos nada y mostramos un mensaje al usuario
            Cliente cliente = new Cliente();
            cliente.Cedula = textCedula.Text;            
            cliente = cServicios.GetCliente(cliente);

            if(cliente == null || cliente.Id == 0)
            {
                MessageBox.Show("Ese Cliente no está registrado");
            }
            else
            {
                labelNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                //Seteamos el objeto
                clienteS = cliente;
                btnGuardar.Enabled = true;
                textCedula.Enabled = false;
                btnBuscarCedula.Enabled = false;
            }                                    
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Crear el objeto
            //Cpmprobar que la placa no exista en la BDD
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Id = IDVehiculo;
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = textMarca.Text;
            vehiculo.Modelo = textModelo.Text;
            vehiculo.Color = textColor.Text;
            vehiculo.Tipo = textTipo.Text;
            vehiculo.Anio = textAnio.Text;
            vehiculo.IdCliente = clienteS.Id;

            if (String.IsNullOrEmpty(vehiculo.Placa) || String.IsNullOrEmpty(vehiculo.Marca) ||
                String.IsNullOrEmpty(vehiculo.Modelo) || String.IsNullOrEmpty(vehiculo.Color) ||
                String.IsNullOrEmpty(vehiculo.Tipo) || String.IsNullOrEmpty(vehiculo.Anio))
            {
                MessageBox.Show($"No debes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!cServicios.IsPlacaValid(vehiculo))
            {
                MessageBox.Show($"Ya esa placa existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (modo.Equals("Guardar"))
                {
                    if (cServicios.AddVehiculo(vehiculo))
                    {
                        this.Dispose();
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Vehiculo Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cServicios.EditVehiculo(vehiculo))
                    {
                        this.Dispose();
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Vehiculo Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
