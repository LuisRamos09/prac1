using System;

namespace PC1.Models
{
    public class Pago
    {
        public string numTarjeta { get; set; }
        public string FechaVencimiento { get; set; }
        public double montoPagar { get; set; }
        public int diasAtrasados { get; set; }
        public double mora { get; set; }
        public double Result { get; set; }
    }

}