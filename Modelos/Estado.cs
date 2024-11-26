namespace ProyectoFinal00.Modelos
{
    public class Estado
    {
        public string Id { get; set; }

        public string NomEstado { get; set; }


        // Cliente 1 a 1 Estado

        public string ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        //Cabaña 1 a 1 E
        public string CabanaId { get; set; }
        public Cabana Cabana { get; set; }

        // Cochera 1 a 1 E
        public string CocheraId { get; set; }
        public Cochera Cochera { get; set; }

        // MedPag 1 a 1 E

        public string MedPagId { get; set; }
        public MedPag MedPag { get; set; }

        // Pago 1 a 1 Estado
        public string PagoId { get; set; }
        public Pago Pago { get; set; }

        // Persona 1 a 1 E
        public string PersonaId { get; set; }
        public Persona Persona { get; set; }

        // Reserva 1 a 1 E
        public string ReservaId { get; set; }
        public Reserva Reserva { get; set; }

        // Rol 1 a 1 estado
        public string RolId { get; set; }
        public Rol Rol { get; set; }

        //Usuario 1 a 1 E
        public string UsuarioId { get; set; }
        public Usuario Usuario  { get; set; }

        // vehiculo 1 a 1 e
        public string VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }











    }
}
