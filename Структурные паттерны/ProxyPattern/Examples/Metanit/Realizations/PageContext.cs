using ProxyPattern.Examples.Metanit.Entity;
using System.Data.Entity;

namespace ProxyPattern.Examples.Metanit.Realizations
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
