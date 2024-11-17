using Microsoft.EntityFrameworkCore;

namespace Locadora.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
