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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OperacionesBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultasBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MantenimientoBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AdministracionBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirBtn = new System.Windows.Forms.ToolStripLabel();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.PanelProveedor = new System.Windows.Forms.Panel();
            this.interfasProveedor1 = new TuManager.InterfasProveedor();
            this.interfasCliente1 = new TuManager.InterfasCliente();
            this.toolStrip1.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.PanelProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OperacionesBtn
            // 
            this.OperacionesBtn.ForeColor = System.Drawing.Color.Black;
            this.OperacionesBtn.Name = "OperacionesBtn";
            this.OperacionesBtn.Size = new System.Drawing.Size(73, 22);
            this.OperacionesBtn.Text = "Operaciones";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ConsultasBtn
            // 
            this.ConsultasBtn.ForeColor = System.Drawing.Color.Black;
            this.ConsultasBtn.Name = "ConsultasBtn";
            this.ConsultasBtn.Size = new System.Drawing.Size(59, 22);
            this.ConsultasBtn.Text = "Consultas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoBtn,
            this.toolStripSeparator1,
            this.OperacionesBtn,
            this.toolStripSeparator2,
            this.ConsultasBtn,
            this.toolStripSeparator3,
            this.ReportesBtn,
            this.toolStripSeparator4,
            this.AdministracionBtn,
            this.SalirBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ReportesBtn
            // 
            this.ReportesBtn.Name = "ReportesBtn";
            this.ReportesBtn.Size = new System.Drawing.Size(53, 22);
            this.ReportesBtn.Text = "Reportes";
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
            this.PanelProveedor.Size = new System.Drawing.Size(334, 351);
            this.PanelProveedor.TabIndex = 1;
            // 
            // interfasProveedor1
            // 
            this.interfasProveedor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasProveedor1.Location = new System.Drawing.Point(11, 3);
            this.interfasProveedor1.Name = "interfasProveedor1";
            this.interfasProveedor1.Size = new System.Drawing.Size(320, 348);
            this.interfasProveedor1.TabIndex = 0;
            // 
            // interfasCliente1
            // 
            this.interfasCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasCliente1.Location = new System.Drawing.Point(1, 3);
            this.interfasCliente1.Name = "interfasCliente1";
            this.interfasCliente1.Size = new System.Drawing.Size(318, 312);
            this.interfasCliente1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(810, 503);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.PanelProveedor);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuManager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelCliente.ResumeLayout(false);
            this.PanelProveedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel OperacionesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ConsultasBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ReportesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton AdministracionBtn;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel SalirBtn;
        private System.Windows.Forms.ToolStripDropDownButton MantenimientoBtn;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Panel PanelCliente;
        private InterfasCliente interfasCliente1;
        private System.Windows.Forms.Panel PanelProveedor;
        private InterfasProveedor interfasProveedor1;
    }
}

