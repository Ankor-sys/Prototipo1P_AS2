using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas forma = new frmVentas();
            forma.MdiParent = this;
            forma.Show();
        }
    }
}
