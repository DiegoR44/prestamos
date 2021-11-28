using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_SISTEMA_DE_PRESTAMOS.Modelos;
namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            ConexionBD.conectar();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int usuario_final=   Sesion.Login(txt_username.Text,txt_contraseña.Text);

            if (usuario_final!=0) {
                this.Hide();

       
                Dashboard irtoDash = new Dashboard(usuario_final);
                irtoDash.Show(this);
               

            } else { MessageBox.Show("NO LOGIADO"); }
        
            
            /*
            Dashboard irtoDash = new Dashboard();
            irtoDash.Show(this);
            this.Hide();    */
       
        
        }
    }
}
