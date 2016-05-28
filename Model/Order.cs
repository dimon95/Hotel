using System;
using System.Collections.Generic;
using Utils;

namespace hotel
{
    public class Order:Entity,IVisitable
    {

        public Guid CheckId { get { return Check.id; } }
        public virtual Payment Check
        {
            get
            {
                return _check.Value;
            }
            private set { _check.Value = value; }
        }
        public virtual ICollection< Reservation> Reservations { get; private set; }


        public Order()
        {
            
        }
        public Order ( Guid id, Payment paym, ICollection<Reservation> res )
            :base(id)
        {
            Check = paym;
            Reservations = res;
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }
        public override string ToString ()
        {

            var result = string.Format(
                       "Order:: Payment:{0} Reservations:",
                        Check
                   );

            foreach ( var res in Reservations )
            {
                result += " " + res + "\n";
            }

            return result;
        }

        private RequiredProperty<Payment> _check = new RequiredProperty<Payment>("payment");

    }
}
