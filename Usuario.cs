using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Usuario
    {
        public int Id { get; set; }
        public string ApellidoyNombre { get; set; }
        public string DNI { get; set; }
        public string FechaNac { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string TipoUser { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public Usuario(string nombre, string dni,string fechanac, string direccion
            , string tel, string email, string tipouser, string user, string pass)
        {
            ApellidoyNombre = nombre;
            DNI = dni;
            FechaNac = fechanac;
            Direccion = direccion;
            Telefono = tel;
            Email = email;
            TipoUser = tipouser;
            User = user;
            Pass = pass;

        }
    }
}
