using hotel;

namespace ModelDBContext.Configurations
{
    public class OrderConfiguration:BasicEntityConfiguration<Order>
    {

        public OrderConfiguration()
        {
        //    Property(o => o.CheckID).IsRequired();
            HasMany(o => o.Reservations).WithOptional();
        }
    }
}