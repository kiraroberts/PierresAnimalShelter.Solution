using Microsoft.EntityFrameworkCore;
using PierresAnimalShelter.Models;

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
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Tony", Species = "Cat", Age = 3, Gender = "Male", Description = "An orange tabby." },
                new Animal { AnimalId = 2, Name = "Gretchen", Species = "Dog", Age = 10, Gender = "Female", Description = "A gray terrier mix." },
                new Animal { AnimalId = 3, Name = "Nacho", Species = "Cat", Age = 4, Gender = "Male", Description = "An orange tabby." },
                new Animal { AnimalId = 4, Name = "Urusula", Species = "Mouse", Age = 1, Gender = "Female", Description = "A white mouse." },
            );
    }
}