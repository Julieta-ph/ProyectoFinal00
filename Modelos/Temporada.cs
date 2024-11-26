namespace ProyectoFinal00.Modelos
{
    public class Temporada
    {
        public string Id { get; set; }
        public string TipoTemp { get; set; }



        // Reserva 1 a 1 Temporada
        public string ReservaId { get; set; }
        public Reserva Reserva { get; set; }
    }
}
