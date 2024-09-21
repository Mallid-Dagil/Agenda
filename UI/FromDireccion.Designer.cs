namespace UI
{
    partial class FromDireccion
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDepartamentos = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cmbIdContacto = new System.Windows.Forms.ComboBox();
            this.cmbIdLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbIdProvincia = new System.Windows.Forms.ComboBox();
            this.cmbIdPais = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblIdContacto = new System.Windows.Forms.Label();
            this.lblIdLocalidad = new System.Windows.Forms.Label();
            this.lblIdProvincia = new System.Windows.Forms.Label();
            this.lblIdPais = new System.Windows.Forms.Label();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(180, 284);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(116, 335);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(51, 284);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDepartamentos
            // 
            this.txtDepartamentos.Location = new System.Drawing.Point(93, 223);
            this.txtDepartamentos.Name = "txtDepartamentos";
            this.txtDepartamentos.Size = new System.Drawing.Size(162, 20);
            this.txtDepartamentos.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(93, 194);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(162, 20);
            this.txtPiso.TabIndex = 6;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(93, 168);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(162, 20);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(93, 142);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(162, 20);
            this.txtCalle.TabIndex = 4;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // cmbIdContacto
            // 
            this.cmbIdContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdContacto.FormattingEnabled = true;
            this.cmbIdContacto.Location = new System.Drawing.Point(93, 113);
            this.cmbIdContacto.Name = "cmbIdContacto";
            this.cmbIdContacto.Size = new System.Drawing.Size(162, 21);
            this.cmbIdContacto.TabIndex = 3;
            // 
            // cmbIdLocalidad
            // 
            this.cmbIdLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdLocalidad.FormattingEnabled = true;
            this.cmbIdLocalidad.Location = new System.Drawing.Point(93, 86);
            this.cmbIdLocalidad.Name = "cmbIdLocalidad";
            this.cmbIdLocalidad.Size = new System.Drawing.Size(162, 21);
            this.cmbIdLocalidad.TabIndex = 2;
            // 
            // cmbIdProvincia
            // 
            this.cmbIdProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProvincia.FormattingEnabled = true;
            this.cmbIdProvincia.Location = new System.Drawing.Point(93, 59);
            this.cmbIdProvincia.Name = "cmbIdProvincia";
            this.cmbIdProvincia.Size = new System.Drawing.Size(162, 21);
            this.cmbIdProvincia.TabIndex = 1;
            this.cmbIdProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbIdProvincia_SelectedIndexChanged);
            // 
            // cmbIdPais
            // 
            this.cmbIdPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdPais.FormattingEnabled = true;
            this.cmbIdPais.Location = new System.Drawing.Point(93, 33);
            this.cmbIdPais.Name = "cmbIdPais";
            this.cmbIdPais.Size = new System.Drawing.Size(162, 21);
            this.cmbIdPais.TabIndex = 0;
            this.cmbIdPais.SelectedIndexChanged += new System.EventHandler(this.cmbIdPais_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(9, 230);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(56, 201);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 18;
            this.lblPiso.Text = "Piso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(42, 175);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 13);
            this.lblAltura.TabIndex = 17;
            this.lblAltura.Text = "* Altura";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(46, 149);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(37, 13);
            this.lblCalle.TabIndex = 16;
            this.lblCalle.Text = "* Calle";
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Location = new System.Drawing.Point(26, 121);
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(57, 13);
            this.lblIdContacto.TabIndex = 15;
            this.lblIdContacto.Text = "* Contacto";
            // 
            // lblIdLocalidad
            // 
            this.lblIdLocalidad.AutoSize = true;
            this.lblIdLocalidad.Location = new System.Drawing.Point(23, 94);
            this.lblIdLocalidad.Name = "lblIdLocalidad";
            this.lblIdLocalidad.Size = new System.Drawing.Size(60, 13);
            this.lblIdLocalidad.TabIndex = 14;
            this.lblIdLocalidad.Text = "* Localidad";
            // 
            // lblIdProvincia
            // 
            this.lblIdProvincia.AutoSize = true;
            this.lblIdProvincia.Location = new System.Drawing.Point(25, 67);
            this.lblIdProvincia.Name = "lblIdProvincia";
            this.lblIdProvincia.Size = new System.Drawing.Size(58, 13);
            this.lblIdProvincia.TabIndex = 13;
            this.lblIdProvincia.Text = "* Provincia";
            // 
            // lblIdPais
            // 
            this.lblIdPais.AutoSize = true;
            this.lblIdPais.Location = new System.Drawing.Point(49, 41);
            this.lblIdPais.Name = "lblIdPais";
            this.lblIdPais.Size = new System.Drawing.Size(34, 13);
            this.lblIdPais.TabIndex = 12;
            this.lblIdPais.Text = "* Pais";
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDireccion.Location = new System.Drawing.Point(277, 33);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDireccion.Size = new System.Drawing.Size(952, 325);
            this.dgvDireccion.TabIndex = 11;
            this.dgvDireccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDireccion_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(662, 386);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FromDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvDireccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDepartamentos);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.cmbIdContacto);
            this.Controls.Add(this.cmbIdLocalidad);
            this.Controls.Add(this.cmbIdProvincia);
            this.Controls.Add(this.cmbIdPais);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblIdContacto);
            this.Controls.Add(this.lblIdLocalidad);
            this.Controls.Add(this.lblIdProvincia);
            this.Controls.Add(this.lblIdPais);
            this.Name = "FromDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direccion";
            this.Load += new System.EventHandler(this.FromDireccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDepartamentos;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cmbIdContacto;
        private System.Windows.Forms.ComboBox cmbIdLocalidad;
        private System.Windows.Forms.ComboBox cmbIdProvincia;
        private System.Windows.Forms.ComboBox cmbIdPais;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblIdContacto;
        private System.Windows.Forms.Label lblIdLocalidad;
        private System.Windows.Forms.Label lblIdProvincia;
        private System.Windows.Forms.Label lblIdPais;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Button btnVolver;
    }
}