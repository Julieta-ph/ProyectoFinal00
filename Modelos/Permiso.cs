namespace ProyectoFinal00.Modelos
{
    public class Permiso
    {
        public string Id { get; set; }
        public string TipoPermiso { get; set; }

        public string RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
