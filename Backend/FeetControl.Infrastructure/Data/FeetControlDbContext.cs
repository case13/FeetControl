using FeetControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FeetControl.Infrastructure.Data
{
    public class FeetControlDbContext : DbContext
    {
        public FeetControlDbContext(DbContextOptions<FeetControlDbContext> options)
            : base(options) { }

        public DbSet<Company> Companies => Set<Company>();
        public DbSet<User> Users => Set<User>();

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<VehicleDriver> VehicleDrivers => Set<VehicleDriver>();

        public DbSet<VehicleDocument> VehicleDocuments => Set<VehicleDocument>();
        public DbSet<DriverDocument> DriverDocuments => Set<DriverDocument>();

        public DbSet<Workshop> Workshops => Set<Workshop>();
        public DbSet<MaintenanceOrder> MaintenanceOrders => Set<MaintenanceOrder>();
        public DbSet<MaintenanceItem> MaintenanceItems => Set<MaintenanceItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // force singular table names
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }

            
            // company to users
            modelBuilder.Entity<User>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to vehicles
            modelBuilder.Entity<Vehicle>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to drivers
            modelBuilder.Entity<Driver>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to workshops
            modelBuilder.Entity<Workshop>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to vehicle documents
            modelBuilder.Entity<VehicleDocument>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to driver documents
            modelBuilder.Entity<DriverDocument>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to maintenance orders
            modelBuilder.Entity<MaintenanceOrder>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // company to maintenance items
            modelBuilder.Entity<MaintenanceItem>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // vehicle driver history
            modelBuilder.Entity<VehicleDriver>()
                .HasOne(x => x.Vehicle)
                .WithMany()
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VehicleDriver>()
                .HasOne(x => x.Driver)
                .WithMany()
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            // vehicle documents
            modelBuilder.Entity<VehicleDocument>()
                .HasOne(x => x.Vehicle)
                .WithMany()
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // driver documents
            modelBuilder.Entity<DriverDocument>()
                .HasOne(x => x.Driver)
                .WithMany()
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            // maintenance order
            modelBuilder.Entity<MaintenanceOrder>()
                .HasOne(x => x.Vehicle)
                .WithMany()
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MaintenanceOrder>()
                .HasOne(x => x.Workshop)
                .WithMany()
                .HasForeignKey(x => x.WorkshopId)
                .OnDelete(DeleteBehavior.Restrict);

            // maintenance item cascade only from maintenance order
            modelBuilder.Entity<MaintenanceItem>()
                .HasOne(x => x.MaintenanceOrder)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.MaintenanceOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // decimal precision for sql server
            modelBuilder.Entity<MaintenanceOrder>()
                .Property(x => x.TotalCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<MaintenanceItem>()
                .Property(x => x.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<MaintenanceItem>()
                .Property(x => x.UnitCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<MaintenanceItem>()
                .Property(x => x.TotalCost)
                .HasPrecision(18, 2);

            // indexes
            modelBuilder.Entity<Vehicle>()
                .HasIndex(x => x.Plate)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(x => x.Email)
                .IsUnique();
        }
    }
}
