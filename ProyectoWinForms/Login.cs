using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWinForms
{
    public partial class InicioSesion : Form
    {
        string usuario = "";
        string contraseña = "";
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text==usuario&& txtContraseña.Text==contraseña)
            {
                AlertaUsCon.Visible= false;
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                AlertaUsCon.Visible= true;
            }
        }
    }
}
