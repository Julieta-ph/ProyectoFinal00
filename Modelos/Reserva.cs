namespace ProyectoFinal00.Modelos
{
    public class Reserva
    {
        public string Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double PrecioReserva { get; set; }


        // Reserva 1 a 1 Temporada
        public Temporada Id { get; set; }

        // Reserva 1 a 1 Pago
        public Pago Id { get; set; }


        // Cliente 1 a M Reserva
        public ICollection<Cliente> Clientes { get; set; }


        // se creo el constructor por sugerencia, averiguar si esta OK
        public Reserva(ICollection<Cliente> clientes)
        {
            Clientes = clientes;
        }

        // Cabana 1 a M Reserva
        public ICollection<Cabana> Cabanas { get; set; }

        // Reserva 1 a 1 estado
        public Estado Id { get; set; }

    }
}
