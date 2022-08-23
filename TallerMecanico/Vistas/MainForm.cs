using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico.Vistas
{
    public partial class MainForm : Form
    {
        Form activeForm;
        public MainForm()
        {
            InitializeComponent();                        
            //Abrir Form del MENU
            Form MenuForm = new Principal.MenuPrincipal();
            mainLabel.Text = "Menu Principal";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;

            //Evento de cierre de aplicacion
            //this.Disposed += ((s, x) =>
            //{
            //    Application.Exit();
            //});
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            formHijo.Activate();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(formHijo);
            this.mainPanel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form MenuForm = new Principal.MenuPrincipal();
            mainLabel.Text = "Menu Principal";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form MenuForm = new Clientes.ClienteForm();
            mainLabel.Text = "Clientes";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Form MenuForm = new Vehiculos.VehiculoForm();
            mainLabel.Text = "Vehiculos";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Form MenuForm = new Servicios.ServicioForm();
            mainLabel.Text = "Servicios Oferta";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            Form MenuForm = new Trabajos.TrabajoForm();
            mainLabel.Text = "Servicios Realizados";
            AbrirFormHijo(MenuForm);
            activeForm = MenuForm;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Login().Show();                
                this.Dispose();
                
                
            }
        }
    }
}
