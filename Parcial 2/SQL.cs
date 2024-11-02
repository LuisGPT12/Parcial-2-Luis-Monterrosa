using Microsoft.SqlServer.Server;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    internal class SQL
    {
        private int id_medicina, stocks;
        private float UnitPrice;
        private String nombre;
        Byte[] img;


        public void asignar(int id, string nombre, int stocks, float UnitPrice, Byte[] img)
        {
            id_medicina = id; this.nombre = nombre; this.stocks = stocks; this.UnitPrice = UnitPrice; this.img = img;
        }
        public int insertarData(NpgsqlConnection conection)
        {
            int cantColumAfe = 0;
            string query = "INSERT INTO INVENTARIO (Id_medicina,Nombre_Medicina,stocks,UnitPrice,\"Imagen\") VALUES (@Id_medicina,@Nombre_Medicina,@stocks,@UnitPrice,@Imagen)";
            using (var cmd = new NpgsqlCommand(query, conection))
            {
                cmd.Parameters.AddWithValue("@id_medicina", id_medicina);
                cmd.Parameters.AddWithValue("@nombre_medicina", nombre);
                cmd.Parameters.AddWithValue("@stocks", stocks);
                cmd.Parameters.AddWithValue("@Unitprice", UnitPrice);
                var imageParameter = cmd.Parameters.Add("@Imagen", NpgsqlDbType.Bytea);
                if (img == null)
                {
                    imageParameter.Value = DBNull.Value;
                }
                else
                {
                    imageParameter.Value = img;
                }
                try
                {

                    if (VerificarExistencia(conection))
                    {
                        cantColumAfe = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("El ID que ingreso ya esta en uso");
                    }
                    if (conection != null && conection.State != ConnectionState.Closed)
                    {
                        conection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
                return cantColumAfe;

            }
        }

        public bool VerificarExistencia(NpgsqlConnection conection)
        {
            bool verifi = false;
            string query = "Select Id_medicina from INVENTARIO where Id_medicina=@id_medicina";
            using (var cmd = new NpgsqlCommand(query, conection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@id_medicina", id_medicina);


                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        verifi = false;
                    }
                    else
                    {
                        verifi = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error en la Consulta = " + ex.Message);
                }
                return verifi;

            }
        }

        public DataTable cosultarInventario(NpgsqlConnection conection)
        {
            int cantColumAfec;
            DataTable dataTable = new DataTable();
            string query = "Select * from INVENTARIO";

            using (var cmd = new NpgsqlCommand(query, conection))
            {
                try
                {
                    NpgsqlDataAdapter data = new NpgsqlDataAdapter(query, conection);
                    data.Fill(dataTable);
                    dataTable.Columns.Add("ImagenMostrar", typeof(Image));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["Imagen"] != DBNull.Value)
                        {
                            try
                            {
                                byte[] imageBytes = (byte[])row["Imagen"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    row["ImagenMostrar"] = Image.FromStream(ms);
                                }
                            }
                            catch (Exception ex)
                            {
                                row["ImagenMostrar"] = null;
                                Console.WriteLine("Error al convertir la imagen: " + ex.Message);
                            }
                        }
                        else
                        {
                            row["ImagenMostrar"] = null;
                        }
                    }

                    if (conection != null && conection.State != ConnectionState.Closed)
                    {
                        conection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error en la Consulta = " + ex.Message);
                }
            }

            return dataTable;

        }
        public int reabastecerI(NpgsqlConnection conection)
        {
            int cantColumAfe = 0;
            string query = "UPDATE INVENTARIO SET stocks = stocks + @stocks WHERE Id_medicina = @id_medicina";
            using (var cmd = new NpgsqlCommand(query, conection))
            {
                cmd.Parameters.AddWithValue("@id_medicina", id_medicina);
                cmd.Parameters.AddWithValue("@stocks", stocks);

                try
                {
                    if (!VerificarExistencia(conection))
                    {
                        cantColumAfe = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("No se Encontro el ID");
                    }
                    if (conection != null && conection.State != ConnectionState.Closed)
                    {
                        conection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
                return cantColumAfe;
            }
        }

        public int cambiarDatos(NpgsqlConnection conection, DataTable data)
        {
            int cantColumAfe = 0;

            using (var transaction = conection.BeginTransaction())
            {
                try
                {
                    foreach (DataRow row in data.Rows)
                    {
                        string query = "UPDATE INVENTARIO SET Nombre_Medicina = @Nombre_Medicina, stocks = @stocks, UnitPrice = @UnitPrice, \"Imagen\" = @Imagen WHERE Id_medicina = @Id_medicina";

                        using (var cmd = new NpgsqlCommand(query, conection, transaction))
                        {

                            id_medicina = row["Id_medicina"] != DBNull.Value ? (int)row["Id_medicina"] : 0;
                            nombre = row["Nombre_Medicina"] != DBNull.Value ? (string)row["Nombre_Medicina"] : string.Empty;
                            stocks = row["stocks"] != DBNull.Value ? (int)row["stocks"] : 0;
                            UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToSingle(row["UnitPrice"]) : 0f;

                            img = row["Imagen"] != DBNull.Value ? (byte[])row["Imagen"] : null;

                            cmd.Parameters.AddWithValue("@id_medicina", id_medicina);
                            cmd.Parameters.AddWithValue("@Nombre_Medicina", nombre);
                            cmd.Parameters.AddWithValue("@stocks", stocks);
                            cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);

                            var imageParameter = cmd.Parameters.Add("@Imagen", NpgsqlDbType.Bytea);
                            imageParameter.Value = img ?? (object)DBNull.Value;

                            if (!VerificarExistencia(conection) )
                            {
                                if (stocks >= 0)
                                    if (UnitPrice > 0)
                                    {
                                        cantColumAfe = cmd.ExecuteNonQuery();
                                    }else
                                        throw new Exception("El Pecio no puede ser negativo.");
                                else
                                        throw new Exception("El stock no puede ser negativo.");

                            }
                            else
                            {
                                throw new Exception("No puede cambiar los ID.");
                            }
                        }
                    }
                    MessageBox.Show("Todos los datos han sido actualizados.");
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    if (conection != null && conection.State != ConnectionState.Closed)
                    {
                        conection.Close();
                    }
                }
                return cantColumAfe;
            }
        }

        public void comprarMedicamento(NpgsqlConnection conection, List<int> listStocks, List<int> listId) { 
            
                int cantColumAfe = 0;

                using (var transaction = conection.BeginTransaction())
                {
                    try
                    {
                        for (int i=0; i < listId.Count;i++)
                        {
                            string query = "UPDATE INVENTARIO SET stocks = stocks - @stocks  WHERE Id_medicina = @Id_medicina";

                        using (var cmd = new NpgsqlCommand(query, conection, transaction))
                            {
                            id_medicina = listId[i];
                            stocks = listStocks[i];

                            cmd.Parameters.AddWithValue("@id_medicina", id_medicina);
                            cmd.Parameters.AddWithValue("@stocks", stocks);

                                if (!VerificarExistencia(conection) && verificarStocks(conection))
                                {
                                    cantColumAfe = cmd.ExecuteNonQuery();

                                }
                                else
                                {
                                    throw new Exception("No hay suficiente stocks");
                                }
                            }
                        }
                        MessageBox.Show("Se han Actualizado los stocks");
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al Comprar: " + ex.Message);
                    }
                    finally
                    {
                        if (conection != null && conection.State != ConnectionState.Closed)
                        {
                            conection.Close();
                        }
                    }
                    
                }
            
        }
        public bool verificarStocks(NpgsqlConnection conection )
        {
            bool verifi = false;
            int stocksDisponible;
            string query = "Select stocks from INVENTARIO where Id_medicina=@id_medicina";
            using (var cmd = new NpgsqlCommand(query, conection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@id_medicina", id_medicina);


                    var result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out stocksDisponible))
                    {
                        if (stocksDisponible >= stocks)
                        {
                            verifi = true;
                        }
                        else
                        {
                            verifi = false;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error en la Consulta = " + ex.Message);
                }
                return verifi;

            }
        }

    }
}


