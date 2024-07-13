namespace ProyectoProgramacionIII.Forms.Usuario
{
    partial class Frm_RegistrarUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Ch_RolConsultar = new System.Windows.Forms.CheckBox();
            this.Ch_RolConsulta = new System.Windows.Forms.CheckBox();
            this.Ch_RolCaja = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(151, 90);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(117, 20);
            this.Txt_Clave.TabIndex = 9;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(151, 50);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(117, 20);
            this.Txt_Usuario.TabIndex = 8;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Location = new System.Drawing.Point(162, 138);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ingresar.TabIndex = 7;
            this.Btn_Ingresar.Text = "Registrar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Ch_RolConsultar
            // 
            this.Ch_RolConsultar.AutoSize = true;
            this.Ch_RolConsultar.Location = new System.Drawing.Point(3, 48);
            this.Ch_RolConsultar.Name = "Ch_RolConsultar";
            this.Ch_RolConsultar.Size = new System.Drawing.Size(262, 17);
            this.Ch_RolConsultar.TabIndex = 12;
            this.Ch_RolConsultar.Text = "Administrar y Modificar Informacion en el programa";
            this.Ch_RolConsultar.UseVisualStyleBackColor = true;
            this.Ch_RolConsultar.CheckedChanged += new System.EventHandler(this.Ch_RolConsultar_CheckedChanged);
            // 
            // Ch_RolConsulta
            // 
            this.Ch_RolConsulta.AutoSize = true;
            this.Ch_RolConsulta.Location = new System.Drawing.Point(3, 11);
            this.Ch_RolConsulta.Name = "Ch_RolConsulta";
            this.Ch_RolConsulta.Size = new System.Drawing.Size(204, 17);
            this.Ch_RolConsulta.TabIndex = 13;
            this.Ch_RolConsulta.Text = " Consultar Informacion en el programa";
            this.Ch_RolConsulta.UseVisualStyleBackColor = true;
            // 
            // Ch_RolCaja
            // 
            this.Ch_RolCaja.AutoSize = true;
            this.Ch_RolCaja.Location = new System.Drawing.Point(3, 82);
            this.Ch_RolCaja.Name = "Ch_RolCaja";
            this.Ch_RolCaja.Size = new System.Drawing.Size(225, 17);
            this.Ch_RolCaja.TabIndex = 14;
            this.Ch_RolCaja.Text = "Permiso para manejar la Caja Registradora";
            this.Ch_RolCaja.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Ch_RolConsulta);
            this.panel1.Controls.Add(this.Ch_RolCaja);
            this.panel1.Controls.Add(this.Ch_RolConsultar);
            this.panel1.Location = new System.Drawing.Point(300, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 111);
            this.panel1.TabIndex = 15;
            // 
            // Frm_RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RegistrarUsuario";
            this.Text = "Frm_RegistrarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.CheckBox Ch_RolConsultar;
        private System.Windows.Forms.CheckBox Ch_RolConsulta;
        private System.Windows.Forms.CheckBox Ch_RolCaja;
        private System.Windows.Forms.Panel panel1;
    }
}