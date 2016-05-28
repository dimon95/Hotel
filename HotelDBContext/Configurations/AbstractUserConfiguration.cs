using hotel;

namespace ModelDBContext.Configurations
{
    class AbstractUserConfiguration : BasicEntityConfiguration<AbstractUser>
    {
        public AbstractUserConfiguration()
        {
            Property(a => a.FirstName).IsRequired();
            Property(a => a.LastName).IsRequired();
            Property(a => a.Login).IsRequired();
            Property(a => a.PasswordHash).IsRequired();
        }
    }
}
