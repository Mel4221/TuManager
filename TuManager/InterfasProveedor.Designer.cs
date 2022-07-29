namespace TuManager
{
    partial class InterfasProveedor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelarRegistro = new System.Windows.Forms.Button();
            this.RegistrarClienteBtn = new System.Windows.Forms.Button();
            this.CorreoProveedor = new System.Windows.Forms.TextBox();
            this.TelProveedor = new System.Windows.Forms.TextBox();
            this.DireccionProveedor = new System.Windows.Forms.TextBox();
            this.RNC = new System.Windows.Forms.TextBox();
            this.ProveedorLbl = new System.Windows.Forms.Label();
            this.EmpresaProveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelarRegistro
            // 
            this.CancelarRegistro.BackColor = System.Drawing.Color.Red;
            this.CancelarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarRegistro.ForeColor = System.Drawing.Color.White;
            this.CancelarRegistro.Location = new System.Drawing.Point(18, 230);
            this.CancelarRegistro.Name = "CancelarRegistro";
            this.CancelarRegistro.Size = new System.Drawing.Size(125, 36);
            this.CancelarRegistro.TabIndex = 17;
            this.CancelarRegistro.Text = "Cancelar Registro";
            this.CancelarRegistro.UseVisualStyleBackColor = false;
            this.CancelarRegistro.Click += new System.EventHandler(this.CancelarRegistro_Click);
            // 
            // RegistrarClienteBtn
            // 
            this.RegistrarClienteBtn.BackColor = System.Drawing.Color.Lime;
            this.RegistrarClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarClienteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistrarClienteBtn.Location = new System.Drawing.Point(176, 230);
            this.RegistrarClienteBtn.Name = "RegistrarClienteBtn";
            this.RegistrarClienteBtn.Size = new System.Drawing.Size(125, 36);
            this.RegistrarClienteBtn.TabIndex = 16;
            this.RegistrarClienteBtn.Text = "Guardar Registro";
            this.RegistrarClienteBtn.UseVisualStyleBackColor = false;
            // 
            // CorreoProveedor
            // 
            this.CorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoProveedor.Location = new System.Drawing.Point(18, 191);
            this.CorreoProveedor.Name = "CorreoProveedor";
            this.CorreoProveedor.Size = new System.Drawing.Size(283, 26);
            this.CorreoProveedor.TabIndex = 15;
            this.CorreoProveedor.Text = "Correo";
            this.CorreoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelProveedor
            // 
            this.TelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelProveedor.Location = new System.Drawing.Point(18, 159);
            this.TelProveedor.Name = "TelProveedor";
            this.TelProveedor.Size = new System.Drawing.Size(283, 26);
            this.TelProveedor.TabIndex = 14;
            this.TelProveedor.Text = "Telefono";
            this.TelProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DireccionProveedor
            // 
            this.DireccionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionProveedor.Location = new System.Drawing.Point(18, 127);
            this.DireccionProveedor.Name = "DireccionProveedor";
            this.DireccionProveedor.Size = new System.Drawing.Size(283, 26);
            this.DireccionProveedor.TabIndex = 13;
            this.DireccionProveedor.Text = "Direccion";
            this.DireccionProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RNC
            // 
            this.RNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNC.Location = new System.Drawing.Point(18, 95);
            this.RNC.Name = "RNC";
            this.RNC.Size = new System.Drawing.Size(283, 26);
            this.RNC.TabIndex = 12;
            this.RNC.Text = "RNC";
            this.RNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProveedorLbl
            // 
            this.ProveedorLbl.AutoSize = true;
            this.ProveedorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLbl.ForeColor = System.Drawing.Color.White;
            this.ProveedorLbl.Location = new System.Drawing.Point(44, 17);
            this.ProveedorLbl.Name = "ProveedorLbl";
            this.ProveedorLbl.Size = new System.Drawing.Size(257, 31);
            this.ProveedorLbl.TabIndex = 10;
            this.ProveedorLbl.Text = "Registrar Proveedor";
            // 
            // EmpresaProveedor
            // 
            this.EmpresaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpresaProveedor.Location = new System.Drawing.Point(18, 63);
            this.EmpresaProveedor.Name = "EmpresaProveedor";
            this.EmpresaProveedor.Size = new System.Drawing.Size(283, 26);
            this.EmpresaProveedor.TabIndex = 18;
            this.EmpresaProveedor.Text = "Empresa";
            this.EmpresaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InterfasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.EmpresaProveedor);
            this.Controls.Add(this.CancelarRegistro);
            this.Controls.Add(this.RegistrarClienteBtn);
            this.Controls.Add(this.CorreoProveedor);
            this.Controls.Add(this.TelProveedor);
            this.Controls.Add(this.DireccionProveedor);
            this.Controls.Add(this.RNC);
            this.Controls.Add(this.ProveedorLbl);
            this.Name = "InterfasProveedor";
            this.Size = new System.Drawing.Size(321, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarRegistro;
        private System.Windows.Forms.Button RegistrarClienteBtn;
        private System.Windows.Forms.TextBox CorreoProveedor;
        private System.Windows.Forms.TextBox TelProveedor;
        private System.Windows.Forms.TextBox DireccionProveedor;
        private System.Windows.Forms.TextBox RNC;
        private System.Windows.Forms.Label ProveedorLbl;
        private System.Windows.Forms.TextBox EmpresaProveedor;
    }
}
