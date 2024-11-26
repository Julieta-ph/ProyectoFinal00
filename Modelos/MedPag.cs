﻿namespace ProyectoFinal00.Modelos
{
    public class MedPag
    {
        public string Id { get; set; }
        public string NombreMedPago { get; set; }
        public string EstadoMedPago { get; set; }



        // Pago 1 a 1 Medio de Pago
        public string PagoId { get; set; }
        public Pago Pago { get; set; }
    }
}