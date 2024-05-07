using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoClase16
{
    public partial class MDINuevo : Form
    {
        public MDINuevo()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MDINuevo mdi = new MDINuevo();
            //mdi.Show();
            FormularioMDISingleton.ObtenerInstancia().Show();
            
        }
    }
}
