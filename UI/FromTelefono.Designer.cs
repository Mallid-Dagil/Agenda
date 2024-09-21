namespace UI
{
    partial class FromTelefono
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
            this.dgvTelefono = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumeroContacto = new System.Windows.Forms.TextBox();
            this.cmbNombreContacto = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblNumeroContacto = new System.Windows.Forms.Label();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.lblIdTipo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelefono
            // 
            this.dgvTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefono.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTelefono.Location = new System.Drawing.Point(299, 36);
            this.dgvTelefono.Name = "dgvTelefono";
            this.dgvTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefono.Size = new System.Drawing.Size(480, 184);
            this.dgvTelefono.TabIndex = 16;
            this.dgvTelefono.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefono_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(128, 197);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(56, 158);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumeroContacto
            // 
            this.txtNumeroContacto.Location = new System.Drawing.Point(117, 96);
            this.txtNumeroContacto.Name = "txtNumeroContacto";
            this.txtNumeroContacto.Size = new System.Drawing.Size(150, 20);
            this.txtNumeroContacto.TabIndex = 12;
            this.txtNumeroContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroContacto_KeyPress);
            // 
            // cmbNombreContacto
            // 
            this.cmbNombreContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreContacto.FormattingEnabled = true;
            this.cmbNombreContacto.Location = new System.Drawing.Point(117, 65);
            this.cmbNombreContacto.Name = "cmbNombreContacto";
            this.cmbNombreContacto.Size = new System.Drawing.Size(150, 21);
            this.cmbNombreContacto.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(117, 36);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // lblNumeroContacto
            // 
            this.lblNumeroContacto.AutoSize = true;
            this.lblNumeroContacto.Location = new System.Drawing.Point(9, 103);
            this.lblNumeroContacto.Name = "lblNumeroContacto";
            this.lblNumeroContacto.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroContacto.TabIndex = 8;
            this.lblNumeroContacto.Text = "Numero Contacto:";
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Location = new System.Drawing.Point(9, 73);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(93, 13);
            this.lblNombreContacto.TabIndex = 9;
            this.lblNombreContacto.Text = "Nombre Contacto:";
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.Location = new System.Drawing.Point(71, 44);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(31, 13);
            this.lblIdTipo.TabIndex = 10;
            this.lblIdTipo.Text = "Tipo:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(469, 239);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FromTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTelefono);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumeroContacto);
            this.Controls.Add(this.cmbNombreContacto);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblNumeroContacto);
            this.Controls.Add(this.lblNombreContacto);
            this.Controls.Add(this.lblIdTipo);
            this.Name = "FromTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telefono";
            this.Load += new System.EventHandler(this.FromTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumeroContacto;
        private System.Windows.Forms.ComboBox cmbNombreContacto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblNumeroContacto;
        private System.Windows.Forms.Label lblNombreContacto;
        private System.Windows.Forms.Label lblIdTipo;
        private System.Windows.Forms.Button btnVolver;
    }
}