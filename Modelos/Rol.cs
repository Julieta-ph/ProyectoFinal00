﻿namespace ProyectoFinal00.Modelos
{
    public class Rol
    {
        public string Id { get; set; }
        public string TipoRol { get; set; }
        


        public Permiso Id { get; set; }


    
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Rol 1 a 1 estado
        public Estado Id { get; set; }

    }
}
