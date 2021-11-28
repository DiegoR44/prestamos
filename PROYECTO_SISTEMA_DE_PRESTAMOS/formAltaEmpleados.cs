using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public partial class formAltaEmpleados : Form
    {
        
        public formAltaEmpleados()
        {
            Dashboard objdash = new Dashboard();
            InitializeComponent();
        }
        Insertar_Trabajador inserccion = new Insertar_Trabajador();


        private void button1_Click(object sender, EventArgs e)
        {
           

        

              inserccion.Alta_Trabajador(
                    NombreTrabajador_txt.Text,
                    txt_nombre_usuario.Text,
                    Convert.ToInt32(txt_sueldo.Text),
                    txt_clave_trabajador.Text,
                    Domicilio_Trabajador_txt.Text,
                    Calendar_emp.SelectionRange.Start,
                   Convert.ToInt32( TelefonoTrabajador_txt.Text),
                    Convert.ToInt32(  cmbox_rol.SelectedValue.ToString()),
                      Convert.ToInt32(cbx_puestos.SelectedValue.ToString())


                );

            MessageBox.Show("Se inserto correctamente");

            Dashboard objDash = new Dashboard();


            //objDash.Listar_Trabajadores();
            
            objDash.Show();
            this.Hide();
          




        }

       Consultas_Trabajadores modificar = new Consultas_Trabajadores();
        private void Nuevo_trabajador_Load(object sender, EventArgs e)
        {

            this.cmbox_rol.DataSource = modificar.Listar_Rol();

            this.cmbox_rol.DisplayMember = "NOMBRE_ROL";

            this.cmbox_rol.ValueMember = "ID_ROL";

            this.cmbox_rol.Refresh();


            this.cbx_puestos.DataSource = modificar.Listar_Puestos();

            this.cbx_puestos.DisplayMember = "NOMBRE_PUESTOS";

            this.cbx_puestos.ValueMember = "NO_PUESTO";

            this.cmbox_rol.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
