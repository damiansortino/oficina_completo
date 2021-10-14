using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Caja
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public List<Recibo> recibos { get; set; }
        public List<Movimiento> movimientos { get; set; }


        public Caja()
        {

        }
    }
}
