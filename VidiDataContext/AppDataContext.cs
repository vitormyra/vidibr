using Microsoft.EntityFrameworkCore;
using vidibr.Models;

namespace vidibr.VidiDataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> VidiBR{get;set;}
    }
}