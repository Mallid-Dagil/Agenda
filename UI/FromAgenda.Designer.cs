namespace UI
{
    partial class FromAgenda
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
            this.txtNombreAgenda = new System.Windows.Forms.TextBox();
            this.lblNombreAgenda = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvfAgenda = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvfAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAgenda
            // 
            this.txtNombreAgenda.Location = new System.Drawing.Point(140, 55);
            this.txtNombreAgenda.Name = "txtNombreAgenda";
            this.txtNombreAgenda.Size = new System.Drawing.Size(205, 20);
            this.txtNombreAgenda.TabIndex = 0;
            this.txtNombreAgenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAgenda_KeyPress);
            // 
            // lblNombreAgenda
            // 
            this.lblNombreAgenda.AutoSize = true;
            this.lblNombreAgenda.Location = new System.Drawing.Point(46, 58);
            this.lblNombreAgenda.Name = "lblNombreAgenda";
            this.lblNombreAgenda.Size = new System.Drawing.Size(84, 13);
            this.lblNombreAgenda.TabIndex = 6;
            this.lblNombreAgenda.Text = "Nombre Agenda";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 127);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(175, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvfAgenda
            // 
            this.dvfAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvfAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvfAgenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvfAgenda.Location = new System.Drawing.Point(405, 55);
            this.dvfAgenda.Name = "dvfAgenda";
            this.dvfAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvfAgenda.Size = new System.Drawing.Size(554, 294);
            this.dvfAgenda.TabIndex = 5;
            this.dvfAgenda.SelectionChanged += new System.EventHandler(this.dvfAgenda_SelectionChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(651, 376);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FromAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dvfAgenda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombreAgenda);
            this.Controls.Add(this.txtNombreAgenda);
            this.Name = "FromAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FromAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvfAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAgenda;
        private System.Windows.Forms.Label lblNombreAgenda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvfAgenda;
        private System.Windows.Forms.Button btnVolver;
    }
}