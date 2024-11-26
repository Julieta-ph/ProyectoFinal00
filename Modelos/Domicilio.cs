namespace ProyectoFinal00.Modelos
{
    public class Domicilio
    {
        public string Id { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Barrio { get; set; }
        public string EntreCalle1 { get; set; }
        public string EntreCalle2 { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }




        // Persona 1 a 1 Domicilio
        public string PersonaId { get; set; }
        public Persona Persona { get; set; }

    }
}
