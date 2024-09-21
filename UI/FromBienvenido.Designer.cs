namespace UI
{
    partial class FromBienvneido
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
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(87, 53);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnAgenda.TabIndex = 0;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(264, 53);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(75, 23);
            this.btnContacto.TabIndex = 0;
            this.btnContacto.Text = "Contacto";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(87, 134);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(75, 23);
            this.btnDireccion.TabIndex = 0;
            this.btnDireccion.Text = "Direccion";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // btnTelefono
            // 
            this.btnTelefono.Location = new System.Drawing.Point(264, 134);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(75, 23);
            this.btnTelefono.TabIndex = 0;
            this.btnTelefono.Text = "Telefono";
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // FromBienvneido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 225);
            this.Controls.Add(this.btnTelefono);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.btnAgenda);
            this.MaximumSize = new System.Drawing.Size(460, 264);
            this.MinimumSize = new System.Drawing.Size(460, 264);
            this.Name = "FromBienvneido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Button btnTelefono;
    }
}