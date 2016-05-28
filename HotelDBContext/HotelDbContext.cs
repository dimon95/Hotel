using System.Data.Entity;
using hotel;

namespace ModelDBContext
{
    public class HotelDbContext : DbContext
    {
//         static HotelDbContext ()
//        {
//            Database.SetInitializer(
//                new DropCreateDatabaseAlways<HotelDbContext>()
//            );
//        }
//
//         public HotelDbContext()
//        {
//            Database.Log = ( s => System.Diagnostics.Debug.WriteLine( s ) ) ;
//        }


         public DbSet<AbstractPlace> AbstractPlaces { get; set; }
         public DbSet<AbstractUser> AbstractUsers { get; set; }
         public DbSet<Admin> Admins { get; set; }
         public DbSet<Client> Clients { get; set; }
         public DbSet<Hall> Halls { get; set; }
        public DbSet<Requisites> Requisitess { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<InfoDiscription> InfoDiscriptions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configurations.AbstractPlaceConfiguration());
            modelBuilder.Configurations.Add(new Configurations.AbstractUserConfiguration());
            modelBuilder.Configurations.Add(new Configurations.AdminConfiguration());
            modelBuilder.Configurations.Add(new Configurations.CartConfiguration());
            modelBuilder.Configurations.Add(new Configurations.ClientConfiguration());
            modelBuilder.Configurations.Add(new Configurations.HallConfiguration());
            modelBuilder.Configurations.Add(new Configurations.InfoDiscriptionConfiguration());
            modelBuilder.Configurations.Add(new Configurations.OrderConfiguration());
            modelBuilder.Configurations.Add(new Configurations.PaymentConfiguration());
            modelBuilder.Configurations.Add(new Configurations.RequisitesConfiguration());
            modelBuilder.Configurations.Add(new Configurations.RoomConfiguration());

        }
    }
}
