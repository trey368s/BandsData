using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BandsData.Models
{
    public class BandContext : DbContext
    {
        public BandContext(DbContextOptions<BandContext> options)
            : base(options)
        { }
        public DbSet<Band> Bands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(
                new Band
                {
                    BandId = 1,
                    name = "Pink Floyd",
                    members = "Syd Barrett, Roger Waters, Richard Wright, David Gilmour, Nick Mason",
                    founded = 1965,
                    origin = "London, England",
                    genre = "Progressive Rock",
                    notableWorks = "Dark Side of the Moon, Another Brick in the Wall, Wish You Were Here"
                },
                new Band
                {
                    BandId = 2,
                    name = "Led Zeppelin",
                    members = "Jimmy Page, Robert Plant, John Bonham, John Paul Jones",
                    founded = 1968,
                    origin = "London, England",
                    genre = "Hard Rock",
                    notableWorks = "Stairway to Heaven, Immigrant Song, Kashmir"
                },
                new Band
                {
                    BandId = 3,
                    name = "The All-American Rejects",
                    members = "Tyson Ritter, Nick Wheeler, Mike Kennerty, Chris Gaylor",
                    founded = 1999,
                    origin = "Stillwater, Oklahoma",
                    genre = "Alternative Rock",
                    notableWorks = "Gives You Hell, My Paper Heart, Dirty Little Secret"
                },
                new Band
                {
                    BandId = 4,
                    name = "The Strokes",
                    members = "Julian Casablancas, Nikolai Fraiture, Albert Hammond, Jr. Fabrizio Moretti, Nick Valensi",
                    founded = 1998,
                    origin = "New York City, New York",
                    genre = "Indie Rock",
                    notableWorks = "The Adults Are Talking, Reptilia, Last Nite"
                }
            );
        }
    }
}
