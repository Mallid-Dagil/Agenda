using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FromContacto : Form
    {
        private List<Contacto> Liscontacto;
        Contacto contacto = new Contacto();
        Contacto aux = new Contacto();
        Agenda agenda = new Agenda();
        ContactoBLL ContactoBLL = new ContactoBLL();
        List<Contacto> contactoFiltrados;
        List<Contacto> listContadorContacto = new List<Contacto>();
        List<Agenda> listContadorAgenda;
        AgendaBLL AgendaBLL = new AgendaBLL();
        DireccionBLL DireccionBLL = new DireccionBLL();
        TelefonoBLL TelefonoBLL = new TelefonoBLL();

        public delegate void CantContactosSuperadaEventHandler(Agenda agenda);
        public event CantContactosSuperadaEventHandler CantContactosSuperadaEvento;

        public FromContacto()
        {
            InitializeComponent();
            listContadorAgenda = AgendaBLL.ObtenerTodo();
            cmbNombreAgenda.DataSource = listContadorAgenda;
            cmbNombreAgenda.DisplayMember = "nombreAgenda";
            //cmbNombreAgenda.SelectedIndex = -1;
 
            CantContactosSuperadaEvento += Agenda_cantContactosSuperadaEvento;
        }


        private void CargarGrilla()
        {
            if (contacto.agenda == cmbNombreAgenda.SelectedItem)
            {
                Agenda agendaSeleccionada = (Agenda)cmbNombreAgenda.SelectedItem;

                contactoFiltrados = ContactoBLL.ContactoFiltrado(agendaSeleccionada.id);

                dgvContacto.DataSource = null;
                dgvContacto.DataSource = contactoFiltrados;
                dgvContacto.Refresh();
                //contactoFiltrados = ContactoBLL.ContactoFiltrado(agendaSeleccionada.id);
                dgvContacto.Columns["AgendaId"].Visible = false;
            }
        }

        private void LimpiarTxt()
        {
            txtNombre.Clear();
            txtSegundoNombre.Clear();
            txtApellido.Clear();

        }

        private void FromContacto_Load(object sender, EventArgs e)
        {
            AgendaBLL agendaBLL = new AgendaBLL();
            List<Agenda> lisAgenda = new List<Agenda>();
            lisAgenda = agendaBLL.ObtenerTodo();
            cmbNombreAgenda.DataSource = lisAgenda;
            cmbNombreAgenda.DisplayMember = "Agenda";
            dgvContacto.Columns["AgendaId"].Visible = false;

            CargarGrilla();
            LimpiarTxt();
        }

        private void dgvContacto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContacto.SelectedRows.Count > 0)
            {
                DataGridViewRow FilaSeleccionada = dgvContacto.SelectedRows[0];
                aux.id = (int)FilaSeleccionada.Cells["id"].Value;
                txtNombre.Text = FilaSeleccionada.Cells["Nombre"].Value.ToString();
                txtSegundoNombre.Text = FilaSeleccionada.Cells["SegundoNombre"].Value.ToString();
                txtApellido.Text = FilaSeleccionada.Cells["Apellido"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text != "")
                {
                    contacto.agenda = (Agenda)cmbNombreAgenda.SelectedItem;
                    contacto.nombre = txtNombre.Text;
                    contacto.segundoNombre = txtSegundoNombre.Text;
                    contacto.Apellido = txtApellido.Text;

                    Agenda agendaseleccionada = (Agenda)cmbNombreAgenda.SelectedItem;
                    if(agendaseleccionada != null)
                    {
                        contacto.AgendaId = agendaseleccionada.id;
                        int id = agenda.id;
                        int cantidadContactos = ContactoBLL.ContactoFiltrado(agendaseleccionada.id).Count();
                        if(cantidadContactos > 9)
                        {
                            CantContactosSuperadaEvento?.Invoke(agendaseleccionada);
                        }
                        else
                        {
                            ContactoBLL.Agregar(contacto);
                        }
                    }
                    MessageBox.Show($"Se Agrego un contacto a la {contacto.agenda}");
                    
                    CargarGrilla();
                    LimpiarTxt();
                }
                else
                {
                    MessageBox.Show("Complete los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agenda_cantContactosSuperadaEvento(Agenda agenda)
        {
            MessageBox.Show($"La lista ya tiene 10 contactos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contacto seleccionado = new Contacto();
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea Eliminar", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Contacto)dgvContacto.CurrentRow.DataBoundItem;
                    if(seleccionado != null)
                    {
                        DireccionBLL.EliminarDireccion(seleccionado.id);
                        TelefonoBLL.EliminarTelefono(seleccionado.id);
                        ContactoBLL.Eliminar(seleccionado);

                        CargarGrilla();
                        dgvContacto.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            LimpiarTxt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtSegundoNombre.Text != "" && txtApellido.Text != "")
                {
                    contacto.agenda = (Agenda)cmbNombreAgenda.SelectedItem;
                    contacto.id = aux.id;
                    contacto.nombre = txtNombre.Text;
                    contacto.segundoNombre = txtSegundoNombre.Text;
                    contacto.Apellido = txtApellido.Text;
                    ContactoBLL.Modificar(contacto);
                    MessageBox.Show($"Se modifico con exito el contacto de la {contacto.agenda}");
                    CargarGrilla();
                    LimpiarTxt();
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

        private void cmbNombreAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Agenda agendaSeleccionada = new Agenda();
                agendaSeleccionada = (Agenda)cmbNombreAgenda.SelectedItem;
                if(agendaSeleccionada != null)
                {
                    contactoFiltrados = ContactoBLL.ContactoFiltrado(agendaSeleccionada.id);
                }


                dgvContacto.DataSource = null;
                dgvContacto.DataSource = contactoFiltrados;
                dgvContacto.Columns["AgendaId"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
        }

        private void ContadorContacto()
        {
            foreach (var agenda in listContadorAgenda)
            {
                List<Contacto> contactosAgenda = ContactoBLL.ContactoFiltrado(agenda.id);
                listContadorContacto.AddRange(contactosAgenda);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
