using Microsoft.EntityFrameworkCore;
using QuantumEvents.Models;

namespace QuantumEvents.Database
{
    public class QuantumEventsContext : DbContext
    {
        public QuantumEventsContext(DbContextOptions<QuantumEventsContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ProfProba> ProfProby { get; set; }
        public DbSet<ExcursionBooking> ExcursionBookings { get; set; }

        public DbSet<UploadedFile> UploadedFiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfProba>().ToTable("ProfProby");
            modelBuilder.Entity<Event>()
                .HasOne(e => e.ProfProba)
                .WithMany(p => p.Events)
                .HasForeignKey(e => e.ProfProbaId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.ProfProba)
                .WithMany()
                .HasForeignKey(b => b.ProfProbaId);

            modelBuilder.Entity<UploadedFile>()
                .HasOne(f => f.Booking)
                .WithMany(b => b.Files)
                .HasForeignKey(f => f.BookingId);
        }
    }
}
