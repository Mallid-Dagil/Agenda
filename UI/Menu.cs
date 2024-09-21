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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromBienvneido bienvneido = new FromBienvneido();
            bienvneido.MdiParent = this;
            bienvneido.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iteracion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xml xml = new Xml();
            xml.MdiParent = this;
            xml.Show();

        }
    }
}
