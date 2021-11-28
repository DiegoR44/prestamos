using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_SISTEMA_DE_PRESTAMOS.Modelos;

namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public partial class Dashboard : Form
    {
        private int user;
    

        public Dashboard(int id_user = 0)
        {
            InitializeComponent();
            user = id_user;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Trabajadores R = new Modificar_Trabajadores();
            R.ShowDialog(this);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO"+user.ToString());
         
            List<Modelos.Vistas> privilegios = Sesion.GetPermisos(user);

            MenuStrip topMenu1 = new MenuStrip();

            foreach (Modelos.Vistas tovista in privilegios) {

                ToolStripMenuItem mPadre = new ToolStripMenuItem(tovista.Nombre_Menu);
                mPadre.TextImageRelation = TextImageRelation.ImageAboveText;
                string rutaicono = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../" )+@tovista.Ruta_Icono);
                mPadre.Image = new Bitmap(rutaicono);
                mPadre.ImageScaling = ToolStripItemImageScaling.SizeToFit;

                foreach (Sub_Vistas sub_vistas in tovista.Lista_Subvistas )
                {
                    ToolStripMenuItem mhijo = new ToolStripMenuItem(sub_vistas.Nombre_Submenu,null,click_para_vistas,sub_vistas.NombreForma);
                    mPadre.DropDownItems.Add(mhijo);
                }
                topMenu1.Items.Add(mPadre);


            }
            this.MainMenuStrip = topMenu1;
            Controls.Add(topMenu1);

            /*
            Listar_Trabajadores();
            */
        }

        private void click_para_vistas(object sender, System.EventArgs e) {

            ToolStripMenuItem vista_seleccionada = (ToolStripMenuItem)sender;

            Assembly asm = Assembly.GetEntryAssembly();
            Type elemento = asm.GetType(asm.GetName().Name + "." + vista_seleccionada.Name);

            if (elemento == null)
            {

                MessageBox.Show("Este formulario no se encontro o no ah sido creado :c");
            }
            else {

                Form formCreado = (Form)Activator.CreateInstance(elemento);
                int encontrado = this.MdiChildren.Where(x=>x.Name == formCreado.Name).ToList().Count();//contamos   cuantos form del mismo nombre hay abiertos

                if (encontrado != 0)//si hay mas de 1 abierto con el mismo nombre de forma  no abre mas

                {


                }
                else {

                    formCreado.MdiParent = this;
                    formCreado.Show();

                }


            
            }

        

        
        }

        /*
        public void Listar_Trabajadores() {

            Consultas_Trabajadores objprod_traba = new Consultas_Trabajadores();

            dataGridView_Trabajadores.DataSource = objprod_traba.Listar_Trabajadores();
        
        }
        */
     

        private void button2_Click(object sender, EventArgs e)
        {
           
            Application.Restart();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
