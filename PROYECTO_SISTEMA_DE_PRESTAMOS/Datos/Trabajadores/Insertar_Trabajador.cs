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
    class Insertar_Trabajador:ConexionBD
    {

         ConexionBD Conexion = new ConexionBD();
        
        SqlCommand comando=new SqlCommand();



        public void  Alta_Trabajador(string nombre_trabajador,string nombre_usuario,int sueldo_empleado,string clave_empleado,string domicilio_empleado,
           DateTime fecha_nacimiento,int telefono_empleado,int id_rol,int no_puesto) {

            comando.Connection = ConexionBD.conectar();
            comando.CommandText = "Agregar_Trabajador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_empleado",nombre_trabajador);
            comando.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
            comando.Parameters.AddWithValue("@sueldo_empleado", sueldo_empleado);
            comando.Parameters.AddWithValue("@clave_empleado", clave_empleado);
            comando.Parameters.AddWithValue("@domicilio_trabajador",domicilio_empleado);         
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@telefono_trabajador", telefono_empleado);
            comando.Parameters.AddWithValue("@Id_Rol", id_rol);
            comando.Parameters.AddWithValue("@Id_Puesto", no_puesto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Conexion.CerrarConexion();

        }
    
    }
}
