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
    partial class ServicioDialog : Form
    {
        ICServicios cServicios = new CServicios();
        int IDServicio { get; set; }
        string modo { get; set; }

        public ServicioDialog(Servicio servicio = null,string modo = "Guardar")
        {
            InitializeComponent();
            this.modo = modo;
            
            if(servicio != null)
            {
                IDServicio = servicio.Id;
                textNombre.Text = servicio.Nombre;
                textDescripcion.Text = servicio.Descripcion;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            servicio.Id = IDServicio;
            servicio.Nombre = textNombre.Text;
            servicio.Descripcion = textDescripcion.Text;
            //Validaciones
            if (String.IsNullOrEmpty(servicio.Nombre) || String.IsNullOrEmpty(servicio.Descripcion))
            {
                MessageBox.Show($"No debes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (modo.Equals("Guardar"))
                {
                    if (cServicios.AddServicio(servicio))
                    {
                        this.Dispose();
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Servicio Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cServicios.EditServicio(servicio))
                    {
                        this.Dispose();
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Servicio Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
