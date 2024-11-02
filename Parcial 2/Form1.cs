using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmFunciones obj = new frmFunciones();
            lblParcial.Visible = false;
            obj.MdiParent = this;
            obj.WindowState= FormWindowState.Maximized; 
            obj.Show();
        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFarmacia obj = new frmFarmacia();
            lblParcial.Visible = false;
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
