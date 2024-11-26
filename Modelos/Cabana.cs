namespace ProyectoFinal00.Modelos
{
    public class Cabana
    {
        public string Id { get; set; }
        public string NomCabana { get; set; }
        public string ObservacionCab { get; set; }
        public double CantHuespedes { get; set; }
        public double PrecioCabana { get; set; }


        // CABAÑA 1 A M RESERVA
        public string ReservaId { get; set; }
        public Reserva Reserva { get; set; }


        // Cabaña a Estado

        public Estado Id { get; set; }
    }
}
