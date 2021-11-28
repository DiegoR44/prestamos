using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public partial class Modificar_Trabajadores : Form
    {
        public Modificar_Trabajadores()
        {
            InitializeComponent();
        }
       Modificado_Trabajadores  modificar = new Modificado_Trabajadores();
        private void Modificar_Trabajadores_Load(object sender, EventArgs e)
        {
            
            this.comboBox_ModificarTra.DataSource = modificar.Listar_Trabajadores();

            this.comboBox_ModificarTra.DisplayMember ="NOMBRE_TRABAJADOR";

            this.comboBox_ModificarTra.ValueMember ="ID_TRABAJADOR";

            this.comboBox_ModificarTra.Refresh();
            


        }



        private void button2_Click(object sender, EventArgs e)
        {
       /*
            string query = "UPDATE TRABAJADORES SET NOMBRETRABAJADOR = @nombretrabajador,EDADTRABAJADOR= @edadtrabajador,DIRECCIONTRABAJADOR= @domiciliotrabajador, TELEFONOTRABAJADOR=@telefonotrabajador WHERE IDTRABAJADOR=@IDTRABAJADOR";
            ConexionBD conexion = new ConexionBD();

            SqlCommand comando = new SqlCommand(query, conexion.conectar());

            comando.Parameters.AddWithValue("@nombretrabajador", textBox_MODIFICARNOMBRE.Text);
            comando.Parameters.AddWithValue("@edadtrabajador", textBox2_MODIFICAREDAD.Text);
            comando.Parameters.AddWithValue("@domiciliotrabajador", textBox3_MODIFICARDIREC.Text);
            comando.Parameters.AddWithValue("@telefonotrabajador", textBox4_MODIFICARTEL.Text);
            comando.Parameters.AddWithValue("@IDTRABAJADOR", comboBox_ModificarTra.SelectedValue.ToString());
            comando.ExecuteNonQuery();

            MessageBox.Show("El registro ah sido actualizado con exito");
            this.comboBox_ModificarTra.Refresh();
            Dashboard objDash = new Dashboard();

            objDash.Listar_Trabajadores();

            objDash.Show();
            this.Hide();
            
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();



        }
    }
}
