using hotelAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace hotelAPI.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {}

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Quarto> Quartos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reserva>().ToTable("Reserva");
            modelBuilder.Entity<Quarto>().ToTable("Quarto");
        }
    }
}
