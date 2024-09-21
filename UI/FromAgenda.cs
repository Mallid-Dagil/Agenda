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
    public partial class FromAgenda : Form
    {
        List<Agenda> listaAgenda;
        AgendaBLL agendaBLL = new AgendaBLL();
        Agenda agenda = new Agenda();
        Agenda aux = new Agenda();
        ContactoBLL contactoBLL = new ContactoBLL();
        List<Contacto> listaContacto = new List<Contacto>();
        DireccionBLL direccionBLL = new DireccionBLL();
        TelefonoBLL telefonoBLL = new TelefonoBLL();
        public FromAgenda()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            try
            {
                listaAgenda = agendaBLL.ObtenerTodo();
                dvfAgenda.DataSource = listaAgenda;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTxt()
        {
            txtNombreAgenda.Clear();
        }

        private void FromAgenda_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarTxt();
        }

        private void dvfAgenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dvfAgenda.SelectedRows.Count > 0)
            {
                DataGridViewRow FilaSeleccionada = dvfAgenda.SelectedRows[0];
                aux.id = (int)FilaSeleccionada.Cells["id"].Value;
                txtNombreAgenda.Text = FilaSeleccionada.Cells["nombreAgenda"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreAgenda.Text != "")
                {
                    agenda.nombreAgenda = txtNombreAgenda.Text;
                    agendaBLL.Agregar(agenda);
                    CargarGrilla();
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
            LimpiarTxt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreAgenda.Text != "")
                {
                    agenda.id = aux.id;
                    agenda.nombreAgenda = txtNombreAgenda.Text;

                    agendaBLL.Modificar(agenda);
                    MessageBox.Show("Se modifico con exito la agenda");
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Completar los campos que desea modficar");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Agenda seleccionado = new Agenda();
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea Eliminar", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Agenda)dvfAgenda.CurrentRow.DataBoundItem;
                    List<Contacto> listaContacto = contactoBLL.ContactoFiltrado(seleccionado.id);
                    foreach (Contacto items in listaContacto)
                    {
                        direccionBLL.EliminarDireccionPorCascada(items.id);
                        telefonoBLL.EliminarTelefonoPorCascada(items.id);
                    }
                    contactoBLL.EliminarContactoPorCascada(seleccionado.id);
                    agendaBLL.Eliminar(seleccionado);
                    CargarGrilla();
                    LimpiarTxt();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
