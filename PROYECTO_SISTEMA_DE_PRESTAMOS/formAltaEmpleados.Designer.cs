namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    partial class formAltaEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreTrabajador_txt = new System.Windows.Forms.TextBox();
            this.Domicilio_Trabajador_txt = new System.Windows.Forms.TextBox();
            this.TelefonoTrabajador_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_clave_trabajador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbox_rol = new System.Windows.Forms.ComboBox();
            this.Calendar_emp = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_puestos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NombreTrabajador_txt
            // 
            this.NombreTrabajador_txt.Location = new System.Drawing.Point(12, 38);
            this.NombreTrabajador_txt.Name = "NombreTrabajador_txt";
            this.NombreTrabajador_txt.Size = new System.Drawing.Size(155, 20);
            this.NombreTrabajador_txt.TabIndex = 0;
            // 
            // Domicilio_Trabajador_txt
            // 
            this.Domicilio_Trabajador_txt.Location = new System.Drawing.Point(192, 38);
            this.Domicilio_Trabajador_txt.Name = "Domicilio_Trabajador_txt";
            this.Domicilio_Trabajador_txt.Size = new System.Drawing.Size(155, 20);
            this.Domicilio_Trabajador_txt.TabIndex = 3;
            // 
            // TelefonoTrabajador_txt
            // 
            this.TelefonoTrabajador_txt.Location = new System.Drawing.Point(12, 85);
            this.TelefonoTrabajador_txt.Name = "TelefonoTrabajador_txt";
            this.TelefonoTrabajador_txt.Size = new System.Drawing.Size(155, 20);
            this.TelefonoTrabajador_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmar Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_clave_trabajador
            // 
            this.txt_clave_trabajador.Location = new System.Drawing.Point(192, 85);
            this.txt_clave_trabajador.Name = "txt_clave_trabajador";
            this.txt_clave_trabajador.Size = new System.Drawing.Size(155, 20);
            this.txt_clave_trabajador.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Clave del trabajador";
            // 
            // cmbox_rol
            // 
            this.cmbox_rol.FormattingEnabled = true;
            this.cmbox_rol.Location = new System.Drawing.Point(27, 139);
            this.cmbox_rol.Name = "cmbox_rol";
            this.cmbox_rol.Size = new System.Drawing.Size(263, 21);
            this.cmbox_rol.TabIndex = 20;
            // 
            // Calendar_emp
            // 
            this.Calendar_emp.Location = new System.Drawing.Point(383, 95);
            this.Calendar_emp.Name = "Calendar_emp";
            this.Calendar_emp.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ROL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "FECHA DE NACIMIENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "PUESTO QUE DESEMPEÑA";
            // 
            // cbx_puestos
            // 
            this.cbx_puestos.FormattingEnabled = true;
            this.cbx_puestos.Location = new System.Drawing.Point(27, 192);
            this.cbx_puestos.Name = "cbx_puestos";
            this.cbx_puestos.Size = new System.Drawing.Size(263, 21);
            this.cbx_puestos.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Asignar nombre de usuario";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(360, 42);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(155, 20);
            this.txt_nombre_usuario.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sueldo ";
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(534, 42);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(155, 20);
            this.txt_sueldo.TabIndex = 30;
            // 
            // formAltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_puestos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calendar_emp);
            this.Controls.Add(this.cmbox_rol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_clave_trabajador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefonoTrabajador_txt);
            this.Controls.Add(this.Domicilio_Trabajador_txt);
            this.Controls.Add(this.NombreTrabajador_txt);
            this.Name = "formAltaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo_trabajador";
            this.Load += new System.EventHandler(this.Nuevo_trabajador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTrabajador_txt;
        private System.Windows.Forms.TextBox Domicilio_Trabajador_txt;
        private System.Windows.Forms.TextBox TelefonoTrabajador_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_clave_trabajador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbox_rol;
        private System.Windows.Forms.MonthCalendar Calendar_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_puestos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sueldo;
    }
}