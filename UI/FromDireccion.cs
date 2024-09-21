using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FromDireccion : Form
    {
        private List<Direccion> listaDireccion;
        private List<Provincia> listaProvincia;
        Direccion direccion = new Direccion();
        Direccion aux = new Direccion();
        DireccionBLL direccionBLL = new DireccionBLL();
        PaisBLL PaisBLL = new PaisBLL();
        ProvinciaBLL ProvinciaBLL = new ProvinciaBLL();
        LocalidadBLL LocalidadBLL = new LocalidadBLL();
        
        public FromDireccion()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            try
            {
                listaDireccion = direccionBLL.ObtenerTodo();
                dgvDireccion.DataSource = listaDireccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
  
        }

        private void LimpiarComboBox()
        {
            cmbIdPais.SelectedIndex = -1;
            cmbIdProvincia.SelectedIndex = -1;
            cmbIdLocalidad.SelectedIndex = -1;
            cmbIdContacto.SelectedIndex = -1;
        }

        private void LimpiarTxt()
        {
            txtAltura.Clear();
            txtCalle.Clear();
            txtDepartamentos.Clear();
            txtPiso.Clear();
        }

        private void FromDireccion_Load(object sender, EventArgs e)
        {
            try
            {
                
                Pais pais = new Pais();
                PaisBLL paisBLL = new PaisBLL();
                List<Pais> listapais = new List<Pais>();
                listapais = paisBLL.ObtenerTodo();
                cmbIdPais.DataSource = listapais;
                cmbIdPais.DisplayMember = "Pais";
                
                
                Provincia provincia = new Provincia();
                ProvinciaBLL provinciaBLL = new ProvinciaBLL();
                List<Provincia> listaProvincia = new List<Provincia>();
                listaProvincia = provinciaBLL.ObtenerTodo();
                cmbIdProvincia.DataSource = listaProvincia;
                cmbIdProvincia.DisplayMember = "Provincia";
                
              
                Localidad localidad = new Localidad();
                LocalidadBLL localidadBLL = new LocalidadBLL();
                List<Localidad> listaLocalidad = new List<Localidad>();
                listaLocalidad = localidadBLL.ObtenerTodo();
                cmbIdLocalidad.DataSource = listaLocalidad;
                cmbIdLocalidad.DisplayMember = "Localidad";
                
                
                Contacto contacto = new Contacto();
                ContactoBLL contactoBLL = new ContactoBLL();
                List<Contacto> listaContacto = new List<Contacto>();
                listaContacto = contactoBLL.ObtenerTodo();
                cmbIdContacto.DataSource = listaContacto;
                cmbIdContacto.DisplayMember = "Apellido";
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LimpiarComboBox();
            CargarGrilla();
            
        }

        private void cmbIdPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Pais paisFiltrado = (Pais)cmbIdPais.SelectedItem;

                if (paisFiltrado != null)
                {
                    cmbIdProvincia.DataSource = ProvinciaBLL.ContactoFiltrado(paisFiltrado.id);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIdProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Provincia provinciaFiltrada = (Provincia)cmbIdProvincia.SelectedItem;

                if (provinciaFiltrada != null)
                {
                    cmbIdLocalidad.DataSource = LocalidadBLL.LocalidadFiltrado(provinciaFiltrada.id);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCalle.Text != "" && txtAltura.Text != "")
                {
                    if(cmbIdPais.SelectedIndex == -1 || cmbIdProvincia.SelectedIndex == -1 || cmbIdLocalidad.SelectedIndex == -1 || cmbIdContacto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un valor en cada ComboBox antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DireccionBLL direccionBLL = new DireccionBLL();
                        
                        Pais paisSeleccionado = new Pais();
                        paisSeleccionado = (Pais)cmbIdPais.SelectedItem;
                        if(paisSeleccionado != null)
                        {
                            direccion.pais.id = paisSeleccionado.id;
                        }

                        Provincia provinciaSelecionad = new Provincia();
                        provinciaSelecionad = (Provincia)cmbIdProvincia.SelectedItem;
                        if(provinciaSelecionad != null)
                        {
                            direccion.provincia.id = provinciaSelecionad.id;
                        }

                        Localidad localidadSeleccionada = new Localidad();
                        localidadSeleccionada = (Localidad)cmbIdLocalidad.SelectedItem;
                        if (localidadSeleccionada != null)
                        {
                            direccion.localidad.id = localidadSeleccionada.id;
                        }

                        Contacto contactoseleccionado = new Contacto();
                           contactoseleccionado = (Contacto)cmbIdContacto.SelectedItem;
                        if(contactoseleccionado != null)
                        {
                            direccion.contacto.id = contactoseleccionado.id;
                        }

                        direccion.calle = txtCalle.Text;
                        direccion.altura = Convert.ToInt32(txtAltura.Text);
                        direccion.piso = txtPiso.Text;
                        direccion.departamento = txtDepartamentos.Text;
                        direccionBLL.Agregar(direccion);
                        //direccion.pais = (Pais)cmbIdPais.SelectedItem;
                        //direccion.provincia = (Provincia)cmbIdProvincia.SelectedItem;
                        //direccion.localidad = (Localidad)cmbIdLocalidad.SelectedItem;
                        //direccion.contacto = (Contacto)cmbIdContacto.SelectedItem;
                        //direccion.calle = txtCalle.Text;
                        //direccion.altura = Convert.ToInt32(txtAltura.Text);
                        //direccion.piso = txtPiso.Text;
                        //direccion.departamento = txtDepartamentos.Text;
                        //direccionBLL.Agregar(direccion);
                        //MessageBox.Show("Se Agrego una direccion de forma exitosa");
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Completa los campos Obligatorios");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LimpiarComboBox();
            LimpiarTxt();

        }

        private void dgvDireccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDireccion.SelectedRows.Count > 0)
            {
                DataGridViewRow FilaSeleccionada = dgvDireccion.SelectedRows[0];
                aux.id = (int)FilaSeleccionada.Cells["id"].Value;
                cmbIdPais.Text = FilaSeleccionada.Cells["Pais"].Value.ToString();
                cmbIdProvincia.Text = FilaSeleccionada.Cells["Provincia"].Value.ToString();
                cmbIdLocalidad.Text = FilaSeleccionada.Cells["Localidad"].Value.ToString();
                cmbIdContacto.Text = FilaSeleccionada.Cells["Contacto"].Value.ToString();
                txtCalle.Text = FilaSeleccionada.Cells["calle"].Value.ToString();
                txtAltura.Text = FilaSeleccionada.Cells["altura"].Value.ToString();
                if (FilaSeleccionada.Cells["piso"].Value != null)
                {
                    txtPiso.Text = FilaSeleccionada.Cells["piso"].Value.ToString();
                }
                if (FilaSeleccionada.Cells["departamento"].Value != null)
                {
                    txtDepartamentos.Text = FilaSeleccionada.Cells["departamento"].Value.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCalle.Text != "" && txtAltura.Text != ""))
                {
                    if(cmbIdPais.SelectedIndex == -1 || cmbIdProvincia.SelectedIndex == -1 || cmbIdLocalidad.SelectedIndex == -1 || cmbIdContacto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un valor en cada desplegable antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DireccionBLL direccionBLL = new DireccionBLL();
                        direccion.id = aux.id;
                        direccion.pais = (Pais)cmbIdPais.SelectedItem;
                        direccion.provincia = (Provincia)cmbIdProvincia.SelectedItem;
                        direccion.localidad = (Localidad)cmbIdLocalidad.SelectedItem;
                        direccion.contacto = (Contacto)cmbIdContacto.SelectedItem;
                        direccion.calle = txtCalle.Text;
                        direccion.altura = Convert.ToInt32(txtAltura.Text);
                        direccion.piso = txtPiso.Text;
                        direccion.departamento = txtDepartamentos.Text;
                        direccionBLL.Modificar(direccion);
                        MessageBox.Show("Su Modificacion se Realizo con exito");
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
            Direccion Seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea Eliminar", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    Seleccionado = (Direccion)dgvDireccion.CurrentRow.DataBoundItem;
                    direccionBLL.Eliminar(Seleccionado);
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

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
