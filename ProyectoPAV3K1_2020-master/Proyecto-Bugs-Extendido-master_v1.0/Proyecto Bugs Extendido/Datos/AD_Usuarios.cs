using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Proyecto_Bugs_Extendido.Datos
{
    class AD_Usuarios
    {
       
         private SqlConnection conexion = new SqlConnection();
         private SqlCommand comando = new SqlCommand();
         private string cadenaConexion = @"Data Source=DESKTOP-H6HTKAB\SQLEXPRESS;Initial Catalog=Bugs_Extendido;User ID=Jonatan66257;password=pav3k4";

        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
    }
}
