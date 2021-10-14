using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(textBox_usuario.Text != null && textBox_pass.Text != null)
            {
                button_aceptar.Enabled = true;
            }
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            
            Sesion nuevasesion = new Sesion(true,);


        }

        private void button_salirlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_NuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario nuevouser = new NuevoUsuario();
            nuevouser.ShowDialog();
        }

        private void link_Recupera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //programar
        }
    }
}
