using Microsoft.EntityFrameworkCore;
using Services.ParkingLot.API.Models.Entities;
using System;

namespace Services.ParkingLot.API.Data
{
    public class ParkingLotDbContext :DbContext
    {
        public ParkingLotDbContext(DbContextOptions<ParkingLotDbContext> options)
            : base(options)
        {
        }
        public DbSet<Floor> Floors { get; set; }

        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Slot> Slot { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<VehicleType> VehicleType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Floor>()
              .HasIndex(u => u.Floor_number)
              .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
