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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto.Visible = true;
            pnlEliminar.Visible = false;
            pnlModificarProducto.Visible = false;
            ConsultarProducto.Visible=false;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto.Visible = false;
            pnlEliminar.Visible = false;
            pnlModificarProducto.Visible = false;
            ConsultarProducto.Visible = true;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto.Visible = false;
            pnlEliminar.Visible = false;
            pnlModificarProducto.Visible = true;
            ConsultarProducto.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto.Visible = false;
            pnlEliminar.Visible = true;
            pnlModificarProducto.Visible = false;
            ConsultarProducto.Visible = false;
        }
    }
}
