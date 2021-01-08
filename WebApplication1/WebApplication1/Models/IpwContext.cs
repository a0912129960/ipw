using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class IpwContext : DbContext
    {
        public IpwContext(DbContextOptions<IpwContext> options) : base(options)
        {
        }

        public DbSet<T_IPATTRIB> T_IPATTRIB { get; set; }
    }
}