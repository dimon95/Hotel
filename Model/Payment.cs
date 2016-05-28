using System;
using Utils;

namespace hotel
{
    public class Payment:Entity,IVisitable
    {
        public Payment()
        {
            
        }
        public Payment ( Guid id, Requisites r, double price )
            : base( id )
        {
            Requisites = r;
            Price = price;
        }

        public Guid RequisitesId { get { return Requisites.id; } }
        public virtual Requisites Requisites
        {
            get;
            private set;
        } 
        public double Price
        {
            get;
            private set;
        }
        public bool IsCompleted
        {
            get;
            private set;
        }

        public void Pay ()
        {
            IsCompleted = true;
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            return string.Format(
                       "Payment:: Requsites:{0} Price:{1} ",
                       Requisites, Price
                   );
        }
    }
}
