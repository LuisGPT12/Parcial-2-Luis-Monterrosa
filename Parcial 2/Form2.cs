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
    public partial class frmFarmacia : Form
    {
        public frmFarmacia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReaastecer reabatecer = new frmReaastecer();
            reabatecer.ShowDialog();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            frmAgregarM agregar = new frmAgregarM();
            agregar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmConsulatI consulta = new frmConsulatI();
            consulta.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmModificarInfo mod = new frmModificarInfo();
            mod.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmComprasMedicamento compra = new frmComprasMedicamento(); 
            compra.ShowDialog();   
        }
    }
}
