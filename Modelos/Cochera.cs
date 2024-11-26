namespace ProyectoFinal00.Modelos
{
    public class Cochera
    {
        public string Id { get; set; }

        public string NomCochera  { get; set; }

        // Cochera 1 a 1 Estado
        public Estado Id { get; set; }
    }
}
