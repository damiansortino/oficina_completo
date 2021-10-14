using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Recibo
    {
        public int Id { get; set; }
        public string Rama { get; set; }
        public string Poliza { get; set; }
        public string Endoso { get; set; }
        public string Asegurado { get; set; }
        public decimal Importe { get; set; }
        public string Vencimiento { get; set; }
        public string Cuota { get; set; }

        //constructor


        public Recibo(string rama, string poliza, string endoso, string importe, string cuota, string asegurado, string vencimiento)
        {
            Importe = Convert.ToDecimal(importe.Substring(0,importe.Length-2) + "." + importe.Substring(importe.Length-2,2));

            Rama = rama;
            Poliza = poliza;
            Endoso = endoso;
            Cuota = cuota;
            Asegurado = asegurado;
            Vencimiento = vencimiento;

        }
    }
}