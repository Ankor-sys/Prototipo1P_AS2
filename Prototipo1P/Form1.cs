using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    
    public partial class Form1 : Form
    {
        private frmVentas forma;
        public Form1()
        {
            InitializeComponent();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(forma == null)
            {
                forma = new frmVentas();
                forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }
        }

        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            forma = null;
        }
    }
}
