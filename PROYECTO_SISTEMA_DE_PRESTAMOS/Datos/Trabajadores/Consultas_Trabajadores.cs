using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    class Consultas_Trabajadores:Insertar_Trabajador
    {
       private  SqlDataReader lector;

        private SqlCommand comando = new SqlCommand();

        public DataTable Listar_Trabajadores()
        {
            
            DataTable Tabla_Trabajadores = new DataTable();
            comando.Connection = conectar();
            comando.CommandText = "Listar_Trabajadores";
            comando.CommandType = CommandType.StoredProcedure;
            lector= comando.ExecuteReader();
            Tabla_Trabajadores.Load(lector);
            lector.Close();
            CerrarConexion();
            return Tabla_Trabajadores;
    
          
        }

        public DataTable Listar_Rol()
        {

            DataTable Tabla_Roles = new DataTable();
            comando.Connection = conectar();
            comando.CommandText = "Listar_Roles";
            comando.CommandType = CommandType.StoredProcedure;
            lector = comando.ExecuteReader();
            Tabla_Roles.Load(lector);
            lector.Close();
            CerrarConexion();
            return Tabla_Roles;


        }
        public DataTable Listar_Puestos()
        {

            DataTable Tabla_Puestos = new DataTable();
            comando.Connection = conectar();
            comando.CommandText = "Listar_Puestos";
            comando.CommandType = CommandType.StoredProcedure;
            lector = comando.ExecuteReader();
            Tabla_Puestos.Load(lector);
            lector.Close();
            CerrarConexion();
            return Tabla_Puestos;


        }





    }
}
