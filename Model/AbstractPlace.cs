using System;
using Utils;


namespace hotel
{
    public abstract class AbstractPlace : Entity
    {
        protected AbstractPlace ( Guid _id, InfoDiscription info )
            : base( _id )
        {
            Info = info;
        }

        public AbstractPlace()
        {
            
        }
        public Guid InfoId { get { return Info.id; } }
        public virtual InfoDiscription Info
        {
            get;
            set;
        }
        public void UpdatePrice ( double price )
        {
            Info.Price = price;
        }
        public void UpdateDiscription ( string disc )
        {
            Info.Discription = disc;
        }
    }
}
