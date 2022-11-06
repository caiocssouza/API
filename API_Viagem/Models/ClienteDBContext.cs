using Microsoft.EntityFrameworkCore;

namespace API_Viagem.Models
{
    public class ClienteDBContext: DbContext 
    {
        public ClienteDBContext(DbContextOptions<ClienteDBContext> options)
            : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }

    }
}
