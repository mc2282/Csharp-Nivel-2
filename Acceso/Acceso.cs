using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso
{ 
        public class AccesoDatos
        {
            private SqlConnection conexion;
            private SqlCommand comando;
            private SqlDataReader lector;

            public AccesoDatos()
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
                comando = new SqlCommand();
            }

            public SqlDataReader Lector
            {
                get { return lector; }
            }

            public SqlCommand Comando
            {
                get { return comando; }
            }

            public void setearConsulta(string consulta)
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }
            public void ejecutarLectura()
            {
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    lector = comando.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void conectarBD()
            {
                conexion.Open();
            }
            public void desconectarBD()
            {
                if (lector != null)

                    lector.Close();

                conexion.Close();
            }
        }
    }


