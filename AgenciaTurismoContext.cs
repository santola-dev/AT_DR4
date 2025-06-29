using AT.Delegates_Eventos;
using AT.Models;
using Microsoft.EntityFrameworkCore;

using AT.Delegates_Eventos;
using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class AgenciaTurismoContext : DbContext
    {
        public AgenciaTurismoContext(DbContextOptions<AgenciaTurismoContext> options) : base(options) { }

        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<CidadeDestino> CidadesDestino { get; set; }
        public DbSet<PaisDestino> PaisesDestino { get; set; }
        public DbSet<Models.PacoteTuristico> PacotesTuristicos { get; set; }
        public DbSet<Models.Reserva> Reservas { get; set; }
        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
