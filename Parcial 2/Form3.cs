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
    public partial class frmConsulatI : Form
    {
        public frmConsulatI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexion conect = new Conexion(); 
            SQL sql = new SQL();
            NpgsqlConnection conexion= conect.crearConexion();
            
            try
            {
                dgvConsultaI.DataSource = sql.cosultarInventario(conexion);
                dgvConsultaI.Columns["Imagen"].Visible = false;
                ((DataGridViewImageColumn)dgvConsultaI.Columns["ImagenMostrar"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
