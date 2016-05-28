using hotel;

namespace ModelDBContext.Configurations
{
    public class RequisitesConfiguration : BasicEntityConfiguration<Requisites>
    {
        public RequisitesConfiguration()
        {
            Property(r => r.AccountNumber).IsRequired();
            Property(r => r.BankIdentifierCode).IsRequired();
            Property(r => r.BeneficiaryBank).IsRequired();
            Property(r => r.id).IsRequired();
            Property(r => r.OrganizationName).IsRequired();
        } 
    }
}