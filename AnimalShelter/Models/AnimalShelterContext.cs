using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Pinchy", Species = "Dog", Age = 3 },
                  new Animal { AnimalId = 2, Name = "Mr. Snuffles", Species = "Snake", Age = 3 },
                  new Animal { AnimalId = 3, Name = "Flighty", Species = "Parrot", Age = 78 },
                  new Animal { AnimalId = 4, Name = "Boopsy", Species = "Cat", Age = 8 },
                  new Animal { AnimalId = 5, Name = "Fluff", Species = "Dog", Age = 1 },
                  new Animal { AnimalId = 2, Name = "Leonardo", Species = "Turtle", Age = 104 },
                  new Animal { AnimalId = 3, Name = "Punge", Species = "Cat", Age = 3 },
                  new Animal { AnimalId = 4, Name = "Diabolical", Species = "Cat", Age = 8 },
                  new Animal { AnimalId = 5, Name = "Tarpy Tar", Species = "Hamster", Age = 1 }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}