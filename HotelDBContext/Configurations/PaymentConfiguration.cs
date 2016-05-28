using hotel;

namespace ModelDBContext.Configurations
{
    public class PaymentConfiguration : BasicEntityConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            Property(c => c.Price).IsRequired();
    //        Property(c => c.RequisiteID).IsRequired();
        }
    }
}