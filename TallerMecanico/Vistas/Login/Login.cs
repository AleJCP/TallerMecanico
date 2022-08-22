using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Disposed += (x, s) =>
            {
                Application.Exit();
            };
        }
    }
}
