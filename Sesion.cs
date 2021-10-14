using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Sesion
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string FechaHoraInicio { get; set; }
        public string FechaHoraFin { get; set; }
        public bool Activa { get; set; }

        public Sesion(bool activa, int loginuser)
        {
            Activa = activa;
            IdUser = loginuser;
        }
    }
}
