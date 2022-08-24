namespace ProyectoWinForms
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresarProducto = new System.Windows.Forms.Panel();
            this.btnLimpiarPro = new System.Windows.Forms.Button();
            this.btnGuardarPro = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlModificarProducto = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtValorMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultarMod = new System.Windows.Forms.Button();
            this.cBModificar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.EliminarProducto = new System.Windows.Forms.Button();
            this.cBProducto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ConsultarProducto = new System.Windows.Forms.Panel();
            this.cBConsultar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.IngresarProducto.SuspendLayout();
            this.pnlModificarProducto.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.ConsultarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IngresarProducto);
            this.groupBox1.Controls.Add(this.pnlEliminar);
            this.groupBox1.Controls.Add(this.ConsultarProducto);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(21, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ingresarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // IngresarProducto
            // 
            this.IngresarProducto.Controls.Add(this.btnLimpiarPro);
            this.IngresarProducto.Controls.Add(this.btnGuardarPro);
            this.IngresarProducto.Controls.Add(this.txtCantidad);
            this.IngresarProducto.Controls.Add(this.txtValor);
            this.IngresarProducto.Controls.Add(this.txtDescripcion);
            this.IngresarProducto.Controls.Add(this.txtCodigo);
            this.IngresarProducto.Controls.Add(this.label5);
            this.IngresarProducto.Controls.Add(this.label4);
            this.IngresarProducto.Controls.Add(this.label3);
            this.IngresarProducto.Controls.Add(this.label2);
            this.IngresarProducto.Location = new System.Drawing.Point(0, 46);
            this.IngresarProducto.Name = "IngresarProducto";
            this.IngresarProducto.Size = new System.Drawing.Size(732, 314);
            this.IngresarProducto.TabIndex = 1;
            this.IngresarProducto.Visible = false;
            // 
            // btnLimpiarPro
            // 
            this.btnLimpiarPro.Location = new System.Drawing.Point(383, 244);
            this.btnLimpiarPro.Name = "btnLimpiarPro";
            this.btnLimpiarPro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarPro.TabIndex = 9;
            this.btnLimpiarPro.Text = "Limpiar";
            this.btnLimpiarPro.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPro
            // 
            this.btnGuardarPro.Location = new System.Drawing.Point(245, 244);
            this.btnGuardarPro.Name = "btnGuardarPro";
            this.btnGuardarPro.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPro.TabIndex = 8;
            this.btnGuardarPro.Text = "Guardar";
            this.btnGuardarPro.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(346, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(346, 129);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(346, 91);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(346, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // pnlModificarProducto
            // 
            this.pnlModificarProducto.Controls.Add(this.btnGuardarCambios);
            this.pnlModificarProducto.Controls.Add(this.txtValorMod);
            this.pnlModificarProducto.Controls.Add(this.label10);
            this.pnlModificarProducto.Controls.Add(this.txtDescMod);
            this.pnlModificarProducto.Controls.Add(this.label8);
            this.pnlModificarProducto.Controls.Add(this.txtCodigoMod);
            this.pnlModificarProducto.Controls.Add(this.label7);
            this.pnlModificarProducto.Controls.Add(this.btnConsultarMod);
            this.pnlModificarProducto.Controls.Add(this.cBModificar);
            this.pnlModificarProducto.Controls.Add(this.label6);
            this.pnlModificarProducto.Location = new System.Drawing.Point(18, 118);
            this.pnlModificarProducto.Name = "pnlModificarProducto";
            this.pnlModificarProducto.Size = new System.Drawing.Size(732, 314);
            this.pnlModificarProducto.TabIndex = 11;
            this.pnlModificarProducto.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(274, 244);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(144, 23);
            this.btnGuardarCambios.TabIndex = 19;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtValorMod
            // 
            this.txtValorMod.Location = new System.Drawing.Point(322, 181);
            this.txtValorMod.Name = "txtValorMod";
            this.txtValorMod.Size = new System.Drawing.Size(100, 20);
            this.txtValorMod.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Valor";
            // 
            // txtDescMod
            // 
            this.txtDescMod.Location = new System.Drawing.Point(322, 149);
            this.txtDescMod.Name = "txtDescMod";
            this.txtDescMod.Size = new System.Drawing.Size(100, 20);
            this.txtDescMod.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // txtCodigoMod
            // 
            this.txtCodigoMod.Location = new System.Drawing.Point(322, 114);
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMod.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo";
            // 
            // btnConsultarMod
            // 
            this.btnConsultarMod.Location = new System.Drawing.Point(314, 70);
            this.btnConsultarMod.Name = "btnConsultarMod";
            this.btnConsultarMod.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarMod.TabIndex = 12;
            this.btnConsultarMod.Text = "Consultar";
            this.btnConsultarMod.UseVisualStyleBackColor = true;
            // 
            // cBModificar
            // 
            this.cBModificar.FormattingEnabled = true;
            this.cBModificar.Location = new System.Drawing.Point(322, 28);
            this.cBModificar.Name = "cBModificar";
            this.cBModificar.Size = new System.Drawing.Size(121, 21);
            this.cBModificar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.EliminarProducto);
            this.pnlEliminar.Controls.Add(this.cBProducto);
            this.pnlEliminar.Controls.Add(this.label14);
            this.pnlEliminar.Location = new System.Drawing.Point(0, 46);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(732, 314);
            this.pnlEliminar.TabIndex = 20;
            this.pnlEliminar.Visible = false;
            // 
            // EliminarProducto
            // 
            this.EliminarProducto.Location = new System.Drawing.Point(322, 140);
            this.EliminarProducto.Name = "EliminarProducto";
            this.EliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.EliminarProducto.TabIndex = 12;
            this.EliminarProducto.Text = "Eliminar";
            this.EliminarProducto.UseVisualStyleBackColor = true;
            // 
            // cBProducto
            // 
            this.cBProducto.FormattingEnabled = true;
            this.cBProducto.Location = new System.Drawing.Point(317, 91);
            this.cBProducto.Name = "cBProducto";
            this.cBProducto.Size = new System.Drawing.Size(121, 21);
            this.cBProducto.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Producto";
            // 
            // ConsultarProducto
            // 
            this.ConsultarProducto.Controls.Add(this.cBConsultar);
            this.ConsultarProducto.Controls.Add(this.dataGridView1);
            this.ConsultarProducto.Controls.Add(this.txtProducto);
            this.ConsultarProducto.Controls.Add(this.btnConsultar);
            this.ConsultarProducto.Controls.Add(this.label9);
            this.ConsultarProducto.Location = new System.Drawing.Point(3, 49);
            this.ConsultarProducto.Name = "ConsultarProducto";
            this.ConsultarProducto.Size = new System.Drawing.Size(732, 314);
            this.ConsultarProducto.TabIndex = 10;
            this.ConsultarProducto.Visible = false;
            // 
            // cBConsultar
            // 
            this.cBConsultar.FormattingEnabled = true;
            this.cBConsultar.Location = new System.Drawing.Point(547, 32);
            this.cBConsultar.Name = "cBConsultar";
            this.cBConsultar.Size = new System.Drawing.Size(121, 21);
            this.cBConsultar.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 196);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(295, 33);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(222, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(314, 70);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Producto";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.pnlModificarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.IngresarProducto.ResumeLayout(false);
            this.IngresarProducto.PerformLayout();
            this.pnlModificarProducto.ResumeLayout(false);
            this.pnlModificarProducto.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.ConsultarProducto.ResumeLayout(false);
            this.ConsultarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel IngresarProducto;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpiarPro;
        private System.Windows.Forms.Button btnGuardarPro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Button EliminarProducto;
        private System.Windows.Forms.ComboBox cBProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel ConsultarProducto;
        private System.Windows.Forms.ComboBox cBConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlModificarProducto;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtValorMod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultarMod;
        private System.Windows.Forms.ComboBox cBModificar;
        private System.Windows.Forms.Label label6;
    }
}