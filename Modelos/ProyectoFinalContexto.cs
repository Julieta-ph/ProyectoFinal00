using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal00.Modelos
{
    public class ProyectoFinalContexto : DbContext
    {
        public ProyectoFinalContexto(DbContextOptions<ProyectoFinalContexto> options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Cabana> Cabanas { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Cochera> Cocheras { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        public DbSet<MedPag> MedPagos { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Rol> Roles { get; set; }

        public DbSet<Permiso> Permisos { get; set; }

        public DbSet<Temporada> Temporadas { get; set; }

        public DbSet<Domicilio> Domicilios { get; set; }

        public DbSet<Estado> Estados { get; set; }

    }
        
           
 }
