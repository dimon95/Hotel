using hotel;

namespace ModelDBContext.Configurations
{
    class ClientConfiguration:BasicEntityConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(a => a.FirstName).IsRequired();
            Property(a => a.LastName).IsRequired();
            Property(a => a.Login).IsRequired();
            Property(a => a.PasswordHash).IsRequired();

           // Property(c => c.ClientCartGuid).IsRequired();
            HasMany(c => c.Orders).WithOptional();
        }
    }
}
