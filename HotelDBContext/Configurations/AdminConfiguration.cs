using hotel;

namespace ModelDBContext.Configurations
{
    public class AdminConfiguration : BasicEntityConfiguration<Admin> 
    {
        public AdminConfiguration()
        {
            Property(a => a.FirstName).IsRequired();
            Property(a => a.LastName).IsRequired();
            Property(a => a.Login).IsRequired();
            Property(a => a.PasswordHash).IsRequired();

            Property(a => a.Access).IsRequired();
        }
    }
}