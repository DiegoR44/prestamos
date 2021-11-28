using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

using PROYECTO_SISTEMA_DE_PRESTAMOS.Modelos;
namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    class Sesion : ConexionBD
    {
        ConexionBD Conexion = new ConexionBD();

        static SqlCommand comando = new SqlCommand();

        public static int Login(string User, string Contra)
        {
            int Us = 0;

            using (SqlConnection con = new SqlConnection(ConexionBD.conexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("LOGIN", con);
                    comando.Parameters.AddWithValue("@NOMBRE_USUARIO", User);
                    comando.Parameters.AddWithValue("@CLAVE_EMPLEADO", Contra);
                    comando.Parameters.Add("@ID_EMPLEADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    comando.ExecuteNonQuery();

                    Us = Convert.ToInt32(comando.Parameters["@ID_EMPLEADO"].Value);


                }
                catch (Exception e)
                {
                    Us = 0;

                }
                return Us;


            }






        }
        
        public static List<Vistas> GetPermisos(int p_idusuario)
        {
            List < Vistas > Permisos_Usuarios = new List<Vistas>();

            using (SqlConnection con = new SqlConnection(ConexionBD.conexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("PRIVILEGIOS", con);
                    comando.Parameters.AddWithValue("@ID_EMPLEADO", p_idusuario);

                    comando.CommandType = CommandType.StoredProcedure;

                    con.Open();




                    XmlReader lectorXML = comando.ExecuteXmlReader();
                    while (lectorXML.Read()) {

                        XDocument documento = XDocument.Load(lectorXML);

                        if (documento.Element("PERMISOS") != null)
                        {
                            Permisos_Usuarios = documento.Element("PERMISOS").Element("DETALLEMENU") == null ? new List<Vistas>():
                                    (from vistas in documento.Element("PERMISOS").Element("DETALLEMENU").Elements("MENU")
                                     select new Vistas()
                                     {
                                         Nombre_Menu = vistas.Element("NOMBRE_MENU").Value,
                                         Ruta_Icono = vistas.Element("ICONO").Value,
                                         Lista_Subvistas = vistas.Element("DETALLESUBMENU") == null ? new List<Sub_Vistas>():
                                         (from subvistas in vistas.Element("DETALLESUBMENU").Elements("SUBMENU")
                                          select new Sub_Vistas()
                                          {
                                              Nombre_Submenu = subvistas.Element("NOMBRE_SUB_MENU").Value,
                                              NombreForma = subvistas.Element("NOMBRE_FORMA").Value
                                          }
                                          ).ToList()


                                     }).ToList(); //PENDIENTE

                        }
                    
                    }

                }
                catch (Exception e)
                {Permisos_Usuarios = new List<Vistas>();}
               
            }

            return Permisos_Usuarios;


        }
    }
}
