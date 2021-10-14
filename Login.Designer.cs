
namespace WinFormsApp1
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.link_NuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.link_Recupera = new System.Windows.Forms.LinkLabel();
            this.button_salirlogin = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(119, 28);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(114, 23);
            this.textBox_usuario.TabIndex = 2;
            this.textBox_usuario.Text = "Usuario";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(119, 78);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(114, 23);
            this.textBox_pass.TabIndex = 3;
            this.textBox_pass.Text = "Contraseña";
            // 
            // link_NuevoUsuario
            // 
            this.link_NuevoUsuario.AutoSize = true;
            this.link_NuevoUsuario.Location = new System.Drawing.Point(123, 299);
            this.link_NuevoUsuario.Name = "link_NuevoUsuario";
            this.link_NuevoUsuario.Size = new System.Drawing.Size(130, 15);
            this.link_NuevoUsuario.TabIndex = 4;
            this.link_NuevoUsuario.TabStop = true;
            this.link_NuevoUsuario.Text = "Crear un nuevo usuario";
            this.link_NuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_NuevoUsuario_LinkClicked);
            // 
            // link_Recupera
            // 
            this.link_Recupera.AutoSize = true;
            this.link_Recupera.Location = new System.Drawing.Point(123, 255);
            this.link_Recupera.Name = "link_Recupera";
            this.link_Recupera.Size = new System.Drawing.Size(131, 15);
            this.link_Recupera.TabIndex = 5;
            this.link_Recupera.TabStop = true;
            this.link_Recupera.Text = "Olvidé mis credenciales";
            this.link_Recupera.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Recupera_LinkClicked);
            // 
            // button_salirlogin
            // 
            this.button_salirlogin.Location = new System.Drawing.Point(81, 199);
            this.button_salirlogin.Name = "button_salirlogin";
            this.button_salirlogin.Size = new System.Drawing.Size(104, 25);
            this.button_salirlogin.TabIndex = 6;
            this.button_salirlogin.Text = "Cancelar / Salir";
            this.button_salirlogin.UseVisualStyleBackColor = true;
            this.button_salirlogin.Click += new System.EventHandler(this.button_salirlogin_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Enabled = false;
            this.button_aceptar.Location = new System.Drawing.Point(81, 156);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(104, 25);
            this.button_aceptar.TabIndex = 7;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 321);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.button_salirlogin);
            this.Controls.Add(this.link_Recupera);
            this.Controls.Add(this.link_NuevoUsuario);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel link_NuevoUsuario;
        private System.Windows.Forms.LinkLabel link_Recupera;
        private System.Windows.Forms.Button button_salirlogin;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.TextBox textBox_pass;
    }
}