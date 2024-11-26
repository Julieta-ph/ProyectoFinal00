namespace ProyectoFinal00.Modelos
{
    public class Vehiculo
    {
        public string Id { get; set; }

        public string PatenteVehiculo { get; set; }

        public string ModeloVehiculo { get; set; }

        public string MarcaVehiculo { get; set; }

        public string EstadoVehiculo { get; set; }



        // Cliente 1 a M Vehiculo
        public ICollection<Cliente> Clientes { get; set; }

        // se creo el constructor por sugerencia, averiguar si esta OK
        public Vehiculo(ICollection<Cliente> clientes)
        {
            Clientes = clientes;
        }
    }
}
