using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Integer_Mark_VI
{
    internal class DBConection
    {
        SqlConnection Conection = new SqlConnection("server=ULTIMATE-ARGAME;database=integer; integrated security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conection.State == ConnectionState.Closed)
            {
                Conection.Open();
            }
            return Conection;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conection.State == ConnectionState.Open)
            {
                Conection.Close();
            }
            return Conection;
        }
        public bool logear (string nusuario, string contraseña)
        {
            bool respuesta = false;
            Conection.Open();
            string consulta = "select * from Usuarios where nusuario='" + nusuario + "' and contraseña='" + contraseña + "'";
            SqlCommand comando = new SqlCommand(consulta, Conection);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            Conection.Close();
            return respuesta;
        }

        public void report()
        {
            //
        }
    }
}
