using System.Data.Entity.ModelConfiguration;

namespace ModelDBContext.Configurations
{
    public abstract class BasicValueConfiguration< TValue > : ComplexTypeConfiguration< TValue > 
        where TValue : class
    {
        protected BasicValueConfiguration ()
        {
        }
    }
}
