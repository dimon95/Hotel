using System;

namespace hotel
{
    public class Room : AbstractPlace, IVisitable
    {
        public Room()
        {
            
        }
        public Room ( Guid id, InfoDiscription info )
            :base(id, info)
        {}

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            return string.Format(
                       "Room:: Discription:{0} ",
                        Info                      
                   );
        }
    }
}
