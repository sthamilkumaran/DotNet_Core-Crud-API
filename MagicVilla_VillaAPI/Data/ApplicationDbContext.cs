using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Tamil",
                    Details = "gdsyghsabhsvbhhsb",
                    ImageUrl = "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg",
                    Occupancy = 5,
                    Rate = 100,
                    Sqtf = 100,
                    Amenity = "test",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Tamilk",
                    Details = "gdsyghsabhsvbhhsb",
                    ImageUrl = "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg",
                    Occupancy = 5,
                    Rate = 100,
                    Sqtf = 100,
                    Amenity = "test",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 3,
                    Name = "Tamill",
                    Details = "gdsyghsabhsvbhhsb",
                    ImageUrl = "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg",
                    Occupancy = 5,
                    Rate = 100,
                    Sqtf = 100,
                    Amenity = "test",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 4,
                    Name = "Kumaran",
                    Details = "gdsyghsabhsvbhhsb",
                    ImageUrl = "https://tk-resume.000webhostapp.com/assets/img/profile1.jpeg",
                    Occupancy = 5,
                    Rate = 100,
                    Sqtf = 100,
                    Amenity = "test",
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
