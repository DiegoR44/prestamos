using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public class ConexionBD
    {
        //CAMBIAR LAS CREDENCIALES DE CONEXION POR LAS SUYAS
       public static  string conexion= @"Data Source=DESKTOP-O0J4JQG\TALLERBD;Initial Catalog=PRESTAMOS;Integrated Security=True";
    public  static    SqlConnection bdconectar = new SqlConnection(conexion);

        public static  SqlConnection conectar()
        {

            try
            {
                if (bdconectar.State == ConnectionState.Closed)
                {
                    bdconectar.Open();
                   
                }
            }
            catch (Exception )
            {
                MessageBox.Show("CONEXIÓN NO  ESTABLECIDA");//cambiar por msj de excepcion por defecto.
            }
            
            return bdconectar;
        }


        public   SqlConnection CerrarConexion()
        {
            if (bdconectar.State == ConnectionState.Open)
                bdconectar.Close();
            return bdconectar;
        }

    }
}
