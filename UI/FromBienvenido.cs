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
    public partial class FromBienvneido : Form
    {
        public FromBienvneido()
        {
            InitializeComponent();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            FromAgenda fromAgenda = new FromAgenda();
            fromAgenda.ShowDialog();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            FromContacto fromContacto = new FromContacto();
            fromContacto.ShowDialog();
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            FromDireccion fromDireccion = new FromDireccion();
            fromDireccion.ShowDialog();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FromTelefono fromTelefono = new FromTelefono();
            fromTelefono.ShowDialog();
        }
    }
}
