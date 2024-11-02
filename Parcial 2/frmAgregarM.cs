using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmAgregarM : Form
    {
        public frmAgregarM()
        {
            InitializeComponent();
        }

        private void frmAgregarM_Load(object sender, EventArgs e)
        {
       
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id, stock;
            float precio;
            string nombre;
            Byte[] img = null;
            if(int.TryParse(txtboxID.Text, out id) && int.TryParse(txtboxStocks.Text,out stock) && float.TryParse(txtboxPrecio.Text, out precio) && !string.IsNullOrWhiteSpace(txtBoxNombre.Text))
            {
                if (stock > 0) {
                    if (precio > 0) { 
                nombre=txtBoxNombre.Text;
                Conexion conect = new Conexion();
                NpgsqlConnection connection = conect.crearConexion();
                SQL sql = new SQL();
                opnfImagen.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (opnfImagen.ShowDialog() == DialogResult.OK)
                {
                    string filePath = opnfImagen.FileName;
                    img = File.ReadAllBytes(filePath);
                }
                sql.asignar(id,nombre,stock,precio,img);
                    if (sql.insertarData(connection) > 0)
                    {
                        MessageBox.Show("Se Ha realizado la Insercio Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("ha Ocurrido un error");
                    }
                }
                else
                {
                    MessageBox.Show("el Stock no puede ser negativo o 0");
                }
                }
                else
                {
                    MessageBox.Show("El precio no puede ser negativo");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
