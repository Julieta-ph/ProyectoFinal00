namespace ProyectoFinal00.Modelos
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Observacion { get; set; }
        public string TipoCliente { get; set; }
        public double CantDeReservas { get; set; }
        public string Ocupacion { get; set; }


        // Persona 1 a 1 Cliente
        public string PersonaId { get; set; }
        public Persona Persona { get; set; }

        // Cliente 1 a M Reserva
        public string ReservaId { get; set; }
        public Reserva Reserva { get; set; }


        // Cliente 1 a M Vehiculo
        public string VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        // Cliente a estado
        public Estado Id { get; set; }

    }
}
