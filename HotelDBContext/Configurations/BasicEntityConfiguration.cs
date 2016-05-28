using System.Data.Entity.ModelConfiguration;
using Utils;

namespace ModelDBContext.Configurations
{
    public abstract class BasicEntityConfiguration< T > : EntityTypeConfiguration< T> 
        where T : Entity
    {
        protected BasicEntityConfiguration ()
        {
            HasKey( e => e.DatabaseId );
       //     Property(e => e.id).IsRequired();
        }
    }
}
