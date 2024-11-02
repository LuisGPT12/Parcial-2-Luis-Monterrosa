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
    public partial class frmComprasMedicamento : Form
    {
        List<int> stocks = new List<int>();
        List<int> ids = new List<int>();
        public frmComprasMedicamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmComprasMedicamento_Load(object sender, EventArgs e)
        {
            Conexion conect = new Conexion();
            SQL sql = new SQL();
            NpgsqlConnection conexion = conect.crearConexion();

            try
            {
                var cosas = sql.cosultarInventario(conexion);
                dgvCompraMostrar.DataSource = cosas;
                dgvCompraMostrar.Columns["Imagen"].Visible = false;
                dgvCompraMostrar.Columns["id_medicina"].Visible = false;
                dgvCompraMostrar.Columns["stocks"].Visible = false;
                dgvCompraMostrar.Columns["ImagenMostrar"].Width = 100;


                cmbBoxMedicinas.DataSource = cosas;
                cmbBoxMedicinas.DisplayMember = "Nombre_Medicina";
                cmbBoxMedicinas.ValueMember = "id_medicina";



        ((DataGridViewImageColumn)dgvCompraMostrar.Columns["ImagenMostrar"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarData_Click(object sender, EventArgs e)
        {
            Conexion conect = new Conexion();
            SQL sql = new SQL();
            NpgsqlConnection conexion = conect.crearConexion();
            
            try
            {
               sql.comprarMedicamento(conexion,stocks,ids);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            int id;
            int stockaCom;
            
            float total=0, precio=0;

            if(int.TryParse(cmbBoxMedicinas.SelectedValue.ToString(), out id) && int.TryParse(txtboxStockCompra.Text,out stockaCom))
            {
                if (stockaCom > 0) {
                    string compara = id.ToString();
                    foreach (DataGridViewRow row in dgvCompraMostrar.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            if (row.Cells["Id_Medicina"].Value.ToString() == compara)
                            {
                                precio = (float)(Convert.ToDecimal(row.Cells["unitprice"].Value));
                                break;
                            }
                        }
                    }

                    lstbCarrito.Items.Add($"Medicina: {cmbBoxMedicinas.Text}  subTotal: {(stockaCom * precio)}");
                    stocks.Add(stockaCom);
                    ids.Add((int)cmbBoxMedicinas.SelectedValue);
                    if (lblTotal.Text.Length > 0)
                    {
                        total = float.Parse(lblTotal.Text);

                        lblTotal.Text = ((stockaCom * precio) + total).ToString();

                    }
                    else
                    {
                        lblTotal.Text = ((stockaCom * precio)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad no puede ser negativa o 0");
                }
                
            }
            
            }

        private void lstbCarrito_DoubleClick(object sender, EventArgs e)
        {
            float total = 0,precio=0;
            string precioS;
            int indice;
            if (lstbCarrito.SelectedItem.ToString() !=null)
            {
                string cadena = lstbCarrito.SelectedItem.ToString();
                string[] cadenaPartida = cadena.Split(new string[] { "subTotal: " }, StringSplitOptions.None);
                precioS = cadenaPartida[1].Trim();
                precio = float.Parse(precioS);
                indice = lstbCarrito.SelectedIndex;
                if (lstbCarrito.SelectedItem != null)
                {
                    if (indice >= 0 && indice < stocks.Count)
                    {
                        stocks.RemoveAt(indice);
                        ids.RemoveAt(indice);
                    }
                    lstbCarrito.Items.Remove(lstbCarrito.SelectedItem);
                    if (lblTotal.Text.Length > 0)
                    {
                        total = float.Parse(lblTotal.Text);
                        lblTotal.Text = ((total) - precio).ToString();
                        
                    }
                    else{
                        lblTotal.Text = (total).ToString();
                    }
                    
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtboxStockCompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

