namespace ProyectoFinal00.Modelos
{
    public class Usuario
    {
        public string Id {  get; set; }
        public string Contraseña { get; set; }

        public Rol Id { get; set; }



        // Persona 1 a 1 Usuario
        public string PersonaId { get; set; }
        public Persona Persona { get; set; }

        // Usuario 1 a 1 Estado
        public Estado Id { get; set; }

    }
}
