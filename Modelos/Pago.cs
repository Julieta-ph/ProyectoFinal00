using System;

namespace ProyectoFinal00.Modelos
{
    public class Pago
    {
        public string Id { get; set; }
        public DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }

        public double MontoTotal { get; set; }

        // public File Adjunto //



        // Pago 1 a 1 Medio de Pago
        public MedPag Id { get; set; }



        // Reserva 1 a 1 Pago
        public string ReservaId { get; set; }
        public Reserva Reserva { get; set; }

    }
}
