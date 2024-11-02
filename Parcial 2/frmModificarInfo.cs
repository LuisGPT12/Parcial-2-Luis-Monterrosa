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
    public partial class frmModificarInfo : Form
    {
        public frmModificarInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarInfo_Load(object sender, EventArgs e)
        {
            Conexion conect = new Conexion();
            SQL sql = new SQL();
            NpgsqlConnection conexion = conect.crearConexion();

            try
            {
                dgvCambiarData.DataSource = sql.cosultarInventario(conexion);
                dgvCambiarData.Columns["Imagen"].Visible = false;
                ((DataGridViewImageColumn)dgvCambiarData.Columns["ImagenMostrar"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarData_Click(object sender, EventArgs e)
        {
            int cantafec;
            Conexion conect = new Conexion();
            SQL sql = new SQL();
            NpgsqlConnection conexion = conect.crearConexion();
            DataTable data;
            try
            {
                data = dgvCambiarData.DataSource as DataTable;
                cantafec= sql.cambiarDatos(conexion,data);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
