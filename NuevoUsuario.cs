using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_CrearUser_Click(object sender, EventArgs e)
        {
            if(textBox_newuser_user.TextLength < 4 | textBox_newuser_pass.TextLength < 6)
            {
                MessageBox.Show(" No se puede crear el usuario por el siguiente motivo:" +
                    " El nombre de usuario no puede estar vacío y" +
                    " debe contener 4 caracteres como mínimo, La contraseña debe ser" +
                    " de al menos 6 caracteres");
            }
            else
            {
                if (listBox_TipoUser.SelectedIndex != 0)
                {
                textBox_llaveadmin.Text = "";
                Usuario nuevousuario = new Usuario(textBox_newuser_ApellidoyNombre.Text, textBox_newuser_DNI.Text
                , textBox_newuser_FechaNac.Text, textBox_newuser_Direccion.Text, textBox_newuser_Tel.Text, textBox_newuser_mail.Text
                , listBox_TipoUser.Text, textBox_newuser_user.Text, textBox_newuser_pass.Text);

                List<Usuario> usuarios = new List<Usuario>();

                usuarios.Add(nuevousuario);
                MessageBox.Show("Usuario creado correctamente");
                this.Close();
                }
                else
                {
                    if (textBox_llaveadmin.Text == "Martina12")
                    {
                        Usuario nuevousuario = new Usuario(textBox_newuser_ApellidoyNombre.Text, textBox_newuser_DNI.Text
                        , textBox_newuser_FechaNac.Text, textBox_newuser_Direccion.Text, textBox_newuser_Tel.Text, textBox_newuser_mail.Text
                        , listBox_TipoUser.Text, textBox_newuser_user.Text, textBox_newuser_pass.Text);

                        List<Usuario> usuarios = new List<Usuario>();

                        usuarios.Add(nuevousuario);
                        MessageBox.Show("Usuario creado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La clave maestra es incorrecta");
                    }
                }

            }

            
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_TipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_TipoUser.SelectedIndex == 0)
            {
                label_llave.Visible = true;
                textBox_llaveadmin.Visible = true;
            }
            else
            {
                label_llave.Visible = false;
                textBox_llaveadmin.Visible = false;
            }
        }
    }
}