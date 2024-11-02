using OxyPlot;
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
    public partial class frmFunciones : Form
    {
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=0, b=0, c=0;
            string res;
            funciones fun = new funciones();

            if (int.TryParse(txtBox1.Text, out a) && int.TryParse(txtBox2.Text, out b)  && int.TryParse(txtBox3.Text, out c))
            {  
                fun.asignarValores(a,b,c);
                plotView1= fun.graficarF(plotView1);
                res= fun.calcularRaices();
                lblResultado.Text = res;
            }
            else
            {
                MessageBox.Show("Error, los valores Debe ser Numericos y debe haber al menos X para ser Ecuacion");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
          
           
        }
    }
    }

