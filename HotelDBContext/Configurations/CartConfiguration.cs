using hotel;

namespace ModelDBContext.Configurations
{
    public class CartConfiguration:BasicEntityConfiguration<Cart>
    {
        public CartConfiguration()
        {
            HasMany<Reservation>(c => c.Reservations).WithOptional();
        }
    }
}