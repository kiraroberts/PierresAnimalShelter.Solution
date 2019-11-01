using Microsoft.EntityFrameworkCore;

namespace PierresAnimalShelter
{
    public class PierresAnimalShelterContext : DbContext
    {
        public PierresAnimalShelterContext(DbContextOptions<PierresAnimalShelterContext> options)
            : base(options)
            {

            }
        public DbSet<Animal> Animals { get; set; }
    }
}