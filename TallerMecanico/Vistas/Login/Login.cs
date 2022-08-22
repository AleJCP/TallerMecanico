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
using TallerMecanico.Vistas;

namespace TallerMecanico
{
    public partial class Login : Form
    {
        ICServicios cservicios = new CServicios();
        public Login()
        {
            InitializeComponent();
            this.Disposed += ExitApp;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            User usuario = new User();
            usuario.Usuario = textUser.Text;
            usuario.Password = textPass.Text;

            if (cservicios.TryLogIn(usuario))
            {
                Form mainForm = new MainForm();
                mainForm.Show();
                //Eliminamos el evento para no cerrar la app
                this.Disposed -= ExitApp;
                this.Dispose();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
