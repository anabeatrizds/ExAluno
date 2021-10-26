using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAula7Cliente
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inclusao Inc;
            Inc = new Inclusao();
            Inc.MdiParent = this;
            Inc.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta con;
            con = new Consulta();
            con.MdiParent = this;
            con.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sob;
            sob = new Sobre();
            sob.Show();
        }
    }
}
