using CodeFirstBasic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data.Context
{
    public class PatikaFirstDbContext : DbContext
    {

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext>options) : base(options)
        {
            
        }

        public DbSet<GameEntity> Games => Set<GameEntity>();
        public DbSet<MovieEntity> Movies => Set<MovieEntity>();







    }
}
