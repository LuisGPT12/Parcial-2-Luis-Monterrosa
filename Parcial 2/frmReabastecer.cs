using Npgsql;
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
    public partial class frmReaastecer : Form
    {
        public frmReaastecer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id, stock;

            if (int.TryParse(txtboxID.Text, out id) && int.TryParse(txtboxStocks.Text, out stock))
            {
                if (stock > 0)
                {
                    Conexion conect = new Conexion();
                    NpgsqlConnection connection = conect.crearConexion();
                    SQL sql = new SQL();

                    sql.asignar(id, null, stock, 0, null);
                    if (sql.reabastecerI(connection) > 0)
                    {
                        MessageBox.Show("Se Ha Actualizado el medicamento");
                    }
                    else
                    {
                        MessageBox.Show("ha Ocurrido un error");
                    }
                }
                else
                {
                    MessageBox.Show("el stock no puede ser negativo, ni 0");
                }
            }
            else {
                MessageBox.Show("Igrese los datos Correctamente");
            }
        }
    }
    }

