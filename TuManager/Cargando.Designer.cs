namespace TuManager
{
    partial class Cargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargando));
            this.ImagenDeCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDeCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenDeCarga
            // 
            this.ImagenDeCarga.Image = ((System.Drawing.Image)(resources.GetObject("ImagenDeCarga.Image")));
            this.ImagenDeCarga.Location = new System.Drawing.Point(12, 12);
            this.ImagenDeCarga.Name = "ImagenDeCarga";
            this.ImagenDeCarga.Size = new System.Drawing.Size(212, 182);
            this.ImagenDeCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenDeCarga.TabIndex = 0;
            this.ImagenDeCarga.TabStop = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(240, 205);
            this.Controls.Add(this.ImagenDeCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando...";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDeCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenDeCarga;
    }
}