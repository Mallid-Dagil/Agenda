namespace UI
{
    partial class FromContacto
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
            this.cmbNombreAgenda = new System.Windows.Forms.ComboBox();
            this.lblNombreAgenda = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNombreAgenda
            // 
            this.cmbNombreAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreAgenda.FormattingEnabled = true;
            this.cmbNombreAgenda.Location = new System.Drawing.Point(138, 38);
            this.cmbNombreAgenda.Name = "cmbNombreAgenda";
            this.cmbNombreAgenda.Size = new System.Drawing.Size(176, 21);
            this.cmbNombreAgenda.TabIndex = 0;
            this.cmbNombreAgenda.SelectedIndexChanged += new System.EventHandler(this.cmbNombreAgenda_SelectedIndexChanged);
            // 
            // lblNombreAgenda
            // 
            this.lblNombreAgenda.AutoSize = true;
            this.lblNombreAgenda.Location = new System.Drawing.Point(48, 46);
            this.lblNombreAgenda.Name = "lblNombreAgenda";
            this.lblNombreAgenda.Size = new System.Drawing.Size(84, 13);
            this.lblNombreAgenda.TabIndex = 8;
            this.lblNombreAgenda.Text = "Nombre Agenda";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(138, 109);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(176, 20);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(42, 116);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNombre.TabIndex = 10;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(88, 151);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 213);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(272, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(149, 283);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvContacto
            // 
            this.dgvContacto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContacto.Location = new System.Drawing.Point(373, 38);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacto.Size = new System.Drawing.Size(559, 268);
            this.dgvContacto.TabIndex = 7;
            this.dgvContacto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacto_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(613, 342);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FromContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvContacto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreAgenda);
            this.Controls.Add(this.cmbNombreAgenda);
            this.Name = "FromContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.FromContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNombreAgenda;
        private System.Windows.Forms.Label lblNombreAgenda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Button btnVolver;
    }
}