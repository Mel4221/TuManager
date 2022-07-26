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
            this.OperacionesBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AdministracionBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirBtn = new System.Windows.Forms.ToolStripLabel();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.interfasCliente1 = new TuManager.InterfasCliente();
            this.PanelProveedor = new System.Windows.Forms.Panel();
            this.interfasProveedor1 = new TuManager.InterfasProveedor();
            this.PanelReportesClientes = new System.Windows.Forms.Panel();
            this.CerrarReporteBtn = new System.Windows.Forms.Button();
            this.ReporteBuscarBtn = new System.Windows.Forms.Button();
            this.ModeloBusqueda = new System.Windows.Forms.TextBox();
            this.MarcaBusqueda = new System.Windows.Forms.TextBox();
            this.CorreoBusqueda = new System.Windows.Forms.TextBox();
            this.NombreBusqueda = new System.Windows.Forms.TextBox();
            this.CodigoBusqueda = new System.Windows.Forms.TextBox();
            this.ViewReportes = new System.Windows.Forms.DataGridView();
            this.TiempoDeCarga = new System.Windows.Forms.Timer(this.components);
            this.PanelReporteProveedor = new System.Windows.Forms.Panel();
            this.NombreProveedor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ReportesProveedor = new System.Windows.Forms.DataGridView();
            this.CerrarReportesPBtn = new System.Windows.Forms.Button();
            this.BuscarReportePBtn = new System.Windows.Forms.Button();
            this.TuManagerMenu.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.PanelProveedor.SuspendLayout();
            this.PanelReportesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportes)).BeginInit();
            this.PanelReporteProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesProveedor)).BeginInit();
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
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
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
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
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
            this.PanelCliente.Size = new System.Drawing.Size(322, 336);
            this.PanelCliente.TabIndex = 1;
            // 
            // interfasCliente1
            // 
            this.interfasCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasCliente1.Location = new System.Drawing.Point(0, 3);
            this.interfasCliente1.Name = "interfasCliente1";
            this.interfasCliente1.Size = new System.Drawing.Size(318, 330);
            this.interfasCliente1.TabIndex = 0;
            // 
            // PanelProveedor
            // 
            this.PanelProveedor.Controls.Add(this.interfasProveedor1);
            this.PanelProveedor.Location = new System.Drawing.Point(218, 69);
            this.PanelProveedor.Name = "PanelProveedor";
            this.PanelProveedor.Size = new System.Drawing.Size(325, 339);
            this.PanelProveedor.TabIndex = 1;
            // 
            // interfasProveedor1
            // 
            this.interfasProveedor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.interfasProveedor1.Location = new System.Drawing.Point(11, 3);
            this.interfasProveedor1.Name = "interfasProveedor1";
            this.interfasProveedor1.Size = new System.Drawing.Size(320, 336);
            this.interfasProveedor1.TabIndex = 0;
            // 
            // PanelReportesClientes
            // 
            this.PanelReportesClientes.Controls.Add(this.CerrarReporteBtn);
            this.PanelReportesClientes.Controls.Add(this.ReporteBuscarBtn);
            this.PanelReportesClientes.Controls.Add(this.ModeloBusqueda);
            this.PanelReportesClientes.Controls.Add(this.MarcaBusqueda);
            this.PanelReportesClientes.Controls.Add(this.CorreoBusqueda);
            this.PanelReportesClientes.Controls.Add(this.NombreBusqueda);
            this.PanelReportesClientes.Controls.Add(this.CodigoBusqueda);
            this.PanelReportesClientes.Controls.Add(this.ViewReportes);
            this.PanelReportesClientes.Location = new System.Drawing.Point(0, 28);
            this.PanelReportesClientes.Name = "PanelReportesClientes";
            this.PanelReportesClientes.Size = new System.Drawing.Size(1030, 463);
            this.PanelReportesClientes.TabIndex = 2;
            // 
            // CerrarReporteBtn
            // 
            this.CerrarReporteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarReporteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarReporteBtn.ForeColor = System.Drawing.Color.Red;
            this.CerrarReporteBtn.Location = new System.Drawing.Point(874, 0);
            this.CerrarReporteBtn.Name = "CerrarReporteBtn";
            this.CerrarReporteBtn.Size = new System.Drawing.Size(144, 30);
            this.CerrarReporteBtn.TabIndex = 7;
            this.CerrarReporteBtn.Text = "Cerrar";
            this.CerrarReporteBtn.UseVisualStyleBackColor = true;
            this.CerrarReporteBtn.Click += new System.EventHandler(this.CerrarReporteBtn_Click);
            // 
            // ReporteBuscarBtn
            // 
            this.ReporteBuscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteBuscarBtn.Location = new System.Drawing.Point(748, 0);
            this.ReporteBuscarBtn.Name = "ReporteBuscarBtn";
            this.ReporteBuscarBtn.Size = new System.Drawing.Size(120, 30);
            this.ReporteBuscarBtn.TabIndex = 6;
            this.ReporteBuscarBtn.Text = "Buscar";
            this.ReporteBuscarBtn.UseVisualStyleBackColor = true;
            // 
            // ModeloBusqueda
            // 
            this.ModeloBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloBusqueda.Location = new System.Drawing.Point(615, 3);
            this.ModeloBusqueda.Name = "ModeloBusqueda";
            this.ModeloBusqueda.Size = new System.Drawing.Size(127, 24);
            this.ModeloBusqueda.TabIndex = 5;
            this.ModeloBusqueda.Text = "Modelo";
            this.ModeloBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ModeloBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // MarcaBusqueda
            // 
            this.MarcaBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaBusqueda.Location = new System.Drawing.Point(429, 3);
            this.MarcaBusqueda.Name = "MarcaBusqueda";
            this.MarcaBusqueda.Size = new System.Drawing.Size(180, 24);
            this.MarcaBusqueda.TabIndex = 4;
            this.MarcaBusqueda.Text = "Marca De Dispositivo";
            this.MarcaBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MarcaBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // CorreoBusqueda
            // 
            this.CorreoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoBusqueda.Location = new System.Drawing.Point(296, 3);
            this.CorreoBusqueda.Name = "CorreoBusqueda";
            this.CorreoBusqueda.Size = new System.Drawing.Size(127, 24);
            this.CorreoBusqueda.TabIndex = 3;
            this.CorreoBusqueda.Text = "Correo";
            this.CorreoBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CorreoBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // NombreBusqueda
            // 
            this.NombreBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreBusqueda.Location = new System.Drawing.Point(136, 3);
            this.NombreBusqueda.Name = "NombreBusqueda";
            this.NombreBusqueda.Size = new System.Drawing.Size(154, 24);
            this.NombreBusqueda.TabIndex = 2;
            this.NombreBusqueda.Text = "Nombre De Cliente";
            this.NombreBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NombreBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // CodigoBusqueda
            // 
            this.CodigoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoBusqueda.Location = new System.Drawing.Point(3, 3);
            this.CodigoBusqueda.Name = "CodigoBusqueda";
            this.CodigoBusqueda.Size = new System.Drawing.Size(127, 24);
            this.CodigoBusqueda.TabIndex = 1;
            this.CodigoBusqueda.Text = "Codigo";
            this.CodigoBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodigoBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // ViewReportes
            // 
            this.ViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewReportes.Location = new System.Drawing.Point(0, 33);
            this.ViewReportes.Name = "ViewReportes";
            this.ViewReportes.Size = new System.Drawing.Size(1024, 406);
            this.ViewReportes.TabIndex = 0;
            // 
            // TiempoDeCarga
            // 
            this.TiempoDeCarga.Interval = 5000;
            // 
            // PanelReporteProveedor
            // 
            this.PanelReporteProveedor.Controls.Add(this.BuscarReportePBtn);
            this.PanelReporteProveedor.Controls.Add(this.CerrarReportesPBtn);
            this.PanelReporteProveedor.Controls.Add(this.ReportesProveedor);
            this.PanelReporteProveedor.Controls.Add(this.textBox3);
            this.PanelReporteProveedor.Controls.Add(this.textBox2);
            this.PanelReporteProveedor.Controls.Add(this.textBox1);
            this.PanelReporteProveedor.Controls.Add(this.NombreProveedor);
            this.PanelReporteProveedor.Location = new System.Drawing.Point(0, 28);
            this.PanelReporteProveedor.Name = "PanelReporteProveedor";
            this.PanelReporteProveedor.Size = new System.Drawing.Size(1030, 460);
            this.PanelReporteProveedor.TabIndex = 8;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProveedor.Location = new System.Drawing.Point(3, 5);
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Size = new System.Drawing.Size(168, 22);
            this.NombreProveedor.TabIndex = 0;
            this.NombreProveedor.Text = "Nombre";
            this.NombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "RNC";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(575, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Telefono";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(351, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Correo";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReportesProveedor
            // 
            this.ReportesProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportesProveedor.Location = new System.Drawing.Point(3, 33);
            this.ReportesProveedor.Name = "ReportesProveedor";
            this.ReportesProveedor.Size = new System.Drawing.Size(1021, 424);
            this.ReportesProveedor.TabIndex = 4;
            // 
            // CerrarReportesPBtn
            // 
            this.CerrarReportesPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarReportesPBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarReportesPBtn.ForeColor = System.Drawing.Color.Red;
            this.CerrarReportesPBtn.Location = new System.Drawing.Point(905, 0);
            this.CerrarReportesPBtn.Name = "CerrarReportesPBtn";
            this.CerrarReportesPBtn.Size = new System.Drawing.Size(113, 30);
            this.CerrarReportesPBtn.TabIndex = 8;
            this.CerrarReportesPBtn.Text = "Cerrar";
            this.CerrarReportesPBtn.UseVisualStyleBackColor = true;
            this.CerrarReportesPBtn.Click += new System.EventHandler(this.CerrarReportesPBtn_Click);
            // 
            // BuscarReportePBtn
            // 
            this.BuscarReportePBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarReportePBtn.Location = new System.Drawing.Point(780, 3);
            this.BuscarReportePBtn.Name = "BuscarReportePBtn";
            this.BuscarReportePBtn.Size = new System.Drawing.Size(101, 25);
            this.BuscarReportePBtn.TabIndex = 9;
            this.BuscarReportePBtn.Text = "Buscar";
            this.BuscarReportePBtn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1030, 485);
            this.Controls.Add(this.PanelReporteProveedor);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.PanelProveedor);
            this.Controls.Add(this.TuManagerMenu);
            this.Controls.Add(this.PanelReportesClientes);
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
            this.PanelReportesClientes.ResumeLayout(false);
            this.PanelReportesClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportes)).EndInit();
            this.PanelReporteProveedor.ResumeLayout(false);
            this.PanelReporteProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesProveedor)).EndInit();
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
        private System.Windows.Forms.Panel PanelReportesClientes;
        private System.Windows.Forms.ToolStripDropDownButton OperacionesBtn;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ReportesBtn;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.DataGridView ViewReportes;
        private System.Windows.Forms.TextBox ModeloBusqueda;
        private System.Windows.Forms.TextBox MarcaBusqueda;
        private System.Windows.Forms.TextBox CorreoBusqueda;
        private System.Windows.Forms.TextBox NombreBusqueda;
        private System.Windows.Forms.TextBox CodigoBusqueda;
        private System.Windows.Forms.Timer TiempoDeCarga;
        private System.Windows.Forms.Button ReporteBuscarBtn;
        private System.Windows.Forms.Button CerrarReporteBtn;
        private System.Windows.Forms.Panel PanelReporteProveedor;
        private System.Windows.Forms.DataGridView ReportesProveedor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NombreProveedor;
        private System.Windows.Forms.Button CerrarReportesPBtn;
        private System.Windows.Forms.Button BuscarReportePBtn;
    }
}

