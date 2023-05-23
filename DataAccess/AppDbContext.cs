using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Image> Images { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PK4OTJR\\SQLEXPRESS01;Initial Catalog=GorselProgramlamaDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Communication).WithOne(c => c.User).HasForeignKey<Communication>(c => c.Id);
            modelBuilder.Entity<User>()
                .HasMany(c => c.Requests)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Houses)
                .WithOne(h => h.User)
                .HasForeignKey(h=> h.UserId);
            modelBuilder.Entity<House>().HasOne(a => a.Address);
            modelBuilder.Entity<Communication>().HasMany(c => c.Adresses);
            modelBuilder
                .Entity<House>()
                .HasMany(h => h.Images)
                .WithOne(i => i.House)
                .HasForeignKey(i => i.HouseId);
            base.OnModelCreating(modelBuilder);
        }


    }
}
