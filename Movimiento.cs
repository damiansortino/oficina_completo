using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Movimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public int IdCaja { get; set; }
        public int IdRecibo { get; set; }
        public int IdUsuario { get; set; }



        public Movimiento(decimal valor, int idcaja, string nombre)
        {
            Valor = valor;
            Nombre = nombre;
            IdCaja = idcaja;

        }

    }
}
