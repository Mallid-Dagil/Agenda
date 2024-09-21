using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FromTelefono : Form
    {
        private List<Telefono> listaTelefono;
        Telefono telefono = new Telefono();
        Telefono aux = new Telefono();
        ContactoBLL ContactoBLL = new ContactoBLL();
        TelefonoTipoBLL TelefonoTipoBLL = new TelefonoTipoBLL();
        TelefonoBLL telefonoBLL = new TelefonoBLL();
        public FromTelefono()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            try
            {
                listaTelefono = telefonoBLL.ObtenerTodo();
                dgvTelefono.DataSource = listaTelefono;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTxt()
        {
            txtNumeroContacto.Clear();
        }

        private void LimpiarComboBox()
        {
            cmbNombreContacto.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
        }

        private void FromTelefono_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ContactoBLL contactoBLL = new ContactoBLL();
            List<Contacto> listaContacto = new List<Contacto>();
            listaContacto = contactoBLL.ObtenerTodo();
            cmbNombreContacto.DataSource = listaContacto;
            cmbNombreContacto.DisplayMember = "Apellido";

            TelefonoTipoBLL telefonoTipoBLL = new TelefonoTipoBLL();
            List<TelefonoTipo> listaTelefonoTipo = new List<TelefonoTipo>();
            listaTelefonoTipo = telefonoTipoBLL.ObtenerTodo();
            cmbTipo.DataSource = listaTelefonoTipo;
            cmbTipo.DisplayMember = "Tipo";
            LimpiarComboBox();
        }

        private void dgvTelefono_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTelefono.SelectedRows.Count > 0)
            {
                DataGridViewRow FilaSeleccionada = dgvTelefono.SelectedRows[0];
                aux.id = (int)FilaSeleccionada.Cells["id"].Value;
                cmbNombreContacto.Text = FilaSeleccionada.Cells["contacto"].Value.ToString();
                cmbTipo.Text = FilaSeleccionada.Cells["telefonoTipo"].Value.ToString();
                txtNumeroContacto.Text = FilaSeleccionada.Cells["numeroContacto"].Value.ToString();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroContacto.Text != "")
                {
                    if (cmbTipo.SelectedIndex == -1 || cmbNombreContacto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un valor en cada deplegable antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        telefono.telefonoTipo = (TelefonoTipo)cmbTipo.SelectedItem;
                        telefono.contacto = (Contacto)cmbNombreContacto.SelectedItem;
                        telefono.NumeroContacto = txtNumeroContacto.Text;
                        telefonoBLL.Agregar(telefono);
                        MessageBox.Show("Se Agrego un Telefono de forma exitosa");
                        CargarGrilla();
                        LimpiarTxt();
                        LimpiarComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroContacto.Text != "")
                {
                    if (cmbTipo.SelectedIndex == -1 || cmbNombreContacto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un valor en cada desplegable antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        telefono.id = aux.id;
                        telefono.telefonoTipo = (TelefonoTipo)cmbTipo.SelectedItem;
                        telefono.contacto = (Contacto)cmbNombreContacto.SelectedItem;
                        telefono.NumeroContacto = txtNumeroContacto.Text;
                        telefonoBLL.Modificar(telefono);
                        MessageBox.Show("Su modificacion se realizo de forma exitosa");
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos que desea modificar");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LimpiarTxt();
            LimpiarComboBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Telefono seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea Eliminar", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Telefono)dgvTelefono.CurrentRow.DataBoundItem;
                    telefonoBLL.Eliminar(seleccionado);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LimpiarTxt();
            LimpiarComboBox();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }
    }
}
