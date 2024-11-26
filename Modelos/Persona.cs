namespace ProyectoFinal00.Modelos
{
    public class Persona
    {
        public string Id { get; set; }
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public DateTime FechaAlta { get; set; }



        // Persona 1 a 1 Cliente
        public Cliente Id { get; set; }

        // Persona 1 a 1 Domicilio
        public Domicilio Id { get; set; }

        // Persona 1 a 1 Usuario
        public Usuario Id { get; set; }



    }
}
