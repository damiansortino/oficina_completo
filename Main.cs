using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }

        private void btn_nuevocobro_Click(object sender, EventArgs e)
        {
            panel_recibo.Visible = true;
            textbox_barra.Focus();
            textbox_barra.SelectAll();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string rama, poliza, endoso, cuota, asegurado, vencimiento, importe;

            rama = textbox_rama.Text;
            poliza = textbox_poliza.Text;
            endoso = textbox_endoso.Text;
            cuota = textbox_cuota.Text;
            importe = textbox_importe.Text;
            asegurado = textbox_asegurado.Text;
            vencimiento = textbox_vencimiento.Text;


            Recibo nuevorecibo = new Recibo(rama, poliza, endoso, importe, cuota, asegurado, vencimiento);

        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            Login nuevoformulogin = new Login();

            nuevoformulogin.ShowDialog();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //crear y leer las listas

            List<Usuario> listadeusuarios = new List<Usuario>();
            List<Sesion> listasesiones = new List<Sesion>();
            
            //crear sesion y usuario inicial y agregar a las listas anteriores

            Usuario superusuario = new Usuario(null, null, null, null, null, null, "Admin", "damiansortino", "Damian12");
            listadeusuarios.Add(superusuario);
            Sesion inactiva = new Sesion(false,0);
            listasesiones.Add(inactiva);

        }
    }
}