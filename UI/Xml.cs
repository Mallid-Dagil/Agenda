using BLL.xml;
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
    public partial class Xml : Form
    {
        xmlBLL acesosBLL = new xmlBLL();
        public Xml()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Texto|*.txt|Archivos XML|*.xml|Todos los archivos|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string contenido = txtXml.Text;

                        acesosBLL.EscribirArchivoTexto(filePath, contenido);
                        MessageBox.Show("Contenido guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtXml.Clear();
                        txtXml.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de Texto|*.txt|Archivos XML|*.xml|Todos los archivos|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        string contenidoLeidoTexto = acesosBLL.LeerArchivoTexto(filePath);
                        txtXml.Text = contenidoLeidoTexto;

                        string objetoLeidoXml = acesosBLL.LeerArchivoXml<string>(filePath);
                        txtXml.Text += objetoLeidoXml;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
