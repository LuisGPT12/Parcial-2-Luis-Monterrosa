using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Parcial_2
{
    internal class Conexion
    {
        String servidor= "localhost";
        String puerto= "5432";
        String usuario="postgres";
        String pasword="1234";
        String bdd="Parcial2";
        NpgsqlConnection conect = new NpgsqlConnection();

        public NpgsqlConnection crearConexion()
        {
            string cadena = $"server={servidor};port={puerto};user id={usuario};password={pasword};database={bdd}";
            try
            {
                conect.ConnectionString=cadena;
                conect.Open();
                MessageBox.Show("Se Conecto Exitosamente");
            }
            catch (Exception ex) { 
             MessageBox.Show("Hubo un error en la Conexion "+ex.Message);
            }
            return conect;
        }
        public void CerrarConexion()
        {
            if (conect != null && conect.State != ConnectionState.Closed) { 
            conect.Close(); 
            }
        }
    }
}
