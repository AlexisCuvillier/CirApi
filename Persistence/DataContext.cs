using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option)  : base(option)
        {
            
        }
        public virtual DbSet<Artist> Artists { get; set; }


    }
}