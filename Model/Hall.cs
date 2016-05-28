using System;

namespace hotel
{
    public class Hall : AbstractPlace, IVisitable
    {
        public Hall()
        {
            
        }
        public Hall ( Guid id, InfoDiscription info )
            : base(id, info)
        { }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            return string.Format(
                       "Hall:: Discription:{0} ",
                        Info
                   );
        }
    }
}
