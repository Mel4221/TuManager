namespace TuManager
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TuManagerMenu = new System.Windows.Forms.ToolStrip();
            this.MantenimientoBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AdministracionBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirBtn = new System.Windows.Forms.ToolStripLabel();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.PanelProveedor = new System.Windows.Forms.Panel();
            this.interfasCliente1 = new TuManager.InterfasCliente();
            this.interfasProveedor1 = new TuManager.InterfasProveedor();
            this.PanelReportes = new System.Windows.Forms.Panel();
            this.OperacionesBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewReportes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TiempoDeCarga = new System.Windows.Forms.Timer(this.components);
            this.TuManagerMenu.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.PanelProveedor.SuspendLayout();
            this.PanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TuManagerMenu
            // 
            this.TuManagerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoBtn,
            this.toolStripSeparator1,
            this.OperacionesBtn,
            this.toolStripSeparator2,
            this.ReportesBtn,
            this.toolStripSeparator4,
            this.AdministracionBtn,
            this.SalirBtn});
            this.TuManagerMenu.Location = new System.Drawing.Point(0, 0);
            this.TuManagerMenu.Name = "TuManagerMenu";
            this.TuManagerMenu.Size = new System.Drawing.Size(1030, 25);
            this.TuManagerMenu.TabIndex = 0;
            this.TuManagerMenu.Text = "toolStrip1";
            // 
            // MantenimientoBtn
            // 
            this.MantenimientoBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.MantenimientoBtn.ForeColor = System.Drawing.Color.Black;
            this.MantenimientoBtn.Name = "MantenimientoBtn";
            this.MantenimientoBtn.Size = new System.Drawing.Size(102, 22);
            this.MantenimientoBtn.Text = "Mantenimiento";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // AdministracionBtn
            // 
            this.AdministracionBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeEmpresasToolStripMenuItem});
            this.AdministracionBtn.Name = "AdministracionBtn";
            this.AdministracionBtn.Size = new System.Drawing.Size(101, 22);
            this.AdministracionBtn.Text = "Administracion";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AdministrarGestion);
            // 
            // gestiónDeEmpresasToolStripMenuItem
            // 
            this.gestiónDeEmpresasToolStripMenuItem.Name = "gestiónDeEmpresasToolStripMenuItem";
            this.gestiónDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestiónDeEmpresasToolStripMenuItem.Text = "Gestión de empresas";
            this.gestiónDeEmpresasToolStripMenuItem.Click += new System.EventHandler(this.AdministrarGestion);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalirBtn.Size = new System.Drawing.Size(29, 22);
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.interfasCliente1);
            this.PanelCliente.Location = new System.Drawing.Point(221, 69);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(322, 339);
            this.PanelCliente.TabIndex = 1;
            // 
            // PanelProveedor
            // 
            this.PanelProveedor.Controls.Add(this.interfasProveedor1);
            this.PanelProveedor.Location = new System.Drawing.Point(218, 69);
            this.PanelProveedor.Name = "PanelProveedor";
            this.PanelProveedor.Size = new System.Drawing.Size(325, 339);
            this.PanelProveedor.TabIndex = 1;
            // 
            // interfasCliente1
            // 
            this.interfasCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasCliente1.Location = new System.Drawing.Point(1, 3);
            this.interfasCliente1.Name = "interfasCliente1";
            this.interfasCliente1.Size = new System.Drawing.Size(318, 312);
            this.interfasCliente1.TabIndex = 0;
            // 
            // interfasProveedor1
            // 
            this.interfasProveedor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasProveedor1.Location = new System.Drawing.Point(11, 3);
            this.interfasProveedor1.Name = "interfasProveedor1";
            this.interfasProveedor1.Size = new System.Drawing.Size(320, 336);
            this.interfasProveedor1.TabIndex = 0;
            // 
            // PanelReportes
            // 
            this.PanelReportes.Controls.Add(this.textBox5);
            this.PanelReportes.Controls.Add(this.textBox4);
            this.PanelReportes.Controls.Add(this.textBox3);
            this.PanelReportes.Controls.Add(this.textBox2);
            this.PanelReportes.Controls.Add(this.textBox1);
            this.PanelReportes.Controls.Add(this.ViewReportes);
            this.PanelReportes.Location = new System.Drawing.Point(0, 28);
            this.PanelReportes.Name = "PanelReportes";
            this.PanelReportes.Size = new System.Drawing.Size(1030, 473);
            this.PanelReportes.TabIndex = 2;
            this.PanelReportes.Visible = false;
            // 
            // OperacionesBtn
            // 
            this.OperacionesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.OperacionesBtn.ForeColor = System.Drawing.Color.Black;
            this.OperacionesBtn.Name = "OperacionesBtn";
            this.OperacionesBtn.Size = new System.Drawing.Size(86, 22);
            this.OperacionesBtn.Text = "Operaciones";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // ReportesBtn
            // 
            this.ReportesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1});
            this.ReportesBtn.Name = "ReportesBtn";
            this.ReportesBtn.Size = new System.Drawing.Size(66, 22);
            this.ReportesBtn.Text = "Reportes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // ViewReportes
            // 
            this.ViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewReportes.Location = new System.Drawing.Point(3, 60);
            this.ViewReportes.Name = "ViewReportes";
            this.ViewReportes.Size = new System.Drawing.Size(1024, 410);
            this.ViewReportes.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(402, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(535, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 20);
            this.textBox5.TabIndex = 5;
            // 
            // TiempoDeCarga
            // 
            this.TiempoDeCarga.Interval = 5000;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1030, 503);
            this.Controls.Add(this.PanelReportes);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.PanelProveedor);
            this.Controls.Add(this.TuManagerMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuManager";
            this.TuManagerMenu.ResumeLayout(false);
            this.TuManagerMenu.PerformLayout();
            this.PanelCliente.ResumeLayout(false);
            this.PanelProveedor.ResumeLayout(false);
            this.PanelReportes.ResumeLayout(false);
            this.PanelReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip TuManagerMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton AdministracionBtn;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel SalirBtn;
        private System.Windows.Forms.ToolStripDropDownButton MantenimientoBtn;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private InterfasCliente interfasCliente1;
        private InterfasProveedor interfasProveedor1;
        public System.Windows.Forms.Panel PanelCliente;
        public System.Windows.Forms.Panel PanelProveedor;
        private System.Windows.Forms.Panel PanelReportes;
        private System.Windows.Forms.ToolStripDropDownButton OperacionesBtn;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ReportesBtn;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.DataGridView ViewReportes;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer TiempoDeCarga;
    }
}

