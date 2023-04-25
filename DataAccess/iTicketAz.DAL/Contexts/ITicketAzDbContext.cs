using iTicketAz.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace iTicketAz.DAL.Contexts
{
    public class ITicketAzDbContext : DbContext
    {
        public ITicketAzDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region EnumValue
            modelBuilder.Entity<EnumValue>()
                 .HasOne<EnumKey>()
                 .WithMany()
                 .HasForeignKey(c => c.KeyId);
            #endregion

            #region Cart
            modelBuilder.Entity<Cart>()
                   .HasDiscriminator<string>("CartInfo")
                   .HasValue<CartUserId>("UserId")
                   .HasValue<CartUserData>("UserData");

            modelBuilder.Entity<CartUserId>()
                .HasBaseType<Cart>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<CartUserData>()
                .HasBaseType<Cart>();
            #endregion

            #region Event
            modelBuilder.Entity<Event>()
                    .HasOne<EnumValue>()
                    .WithMany()
                    .HasForeignKey(c => c.AgeRestrictionId);
            modelBuilder.Entity<Event>()
                .HasOne<EnumValue>()
                .WithMany()
                .HasForeignKey(c => c.LanguageId);
            #endregion

            #region Ticket
            modelBuilder.Entity<Ticket>()
                    .HasOne<PriceType>()
                    .WithMany()
                    .HasForeignKey(c => c.TypeId);
            modelBuilder.Entity<Ticket>()
                .HasOne<Event>()
                .WithMany(c => c.Tickets)
                .HasForeignKey(c => c.EventId);
            #endregion

            #region Photo
            modelBuilder.Entity<Photo>()
                   .HasOne<Event>()
                   .WithMany(c => c.Photos)
                   .HasForeignKey(c => c.EventId); 
            #endregion
        }

        #region DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Photo> Photos { get; set; } 
        #endregion
    }
}
