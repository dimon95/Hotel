using System;
using System.Collections.Generic;
using System.Text;


namespace hotel
{
    public class Cart : Utils.Entity, IVisitable
    {
        public virtual ICollection<Reservation> Reservations
        {
            get;
            private set;
        } 

        public Cart()
        {
            Reservations = new List<Reservation>();
        }
        public Cart(Guid id)
            : base(id)
        {
            Reservations = new List<Reservation>();
        }
        public void AddReservation ( Reservation r )
        {
            Reservations.Add( r );
        }
        public void RemoveReservation ( Reservation r )
        {
            Reservations.Remove( r );
        }

        public void Clear ()
        {
            Reservations = new List<Reservation>();
        }
        public double GetTotalPrice ()
        {
            double total = 0;

            foreach ( Reservation r in Reservations )
            {
                total += r.Place.Info.Price * r.ReservationPeriod;
            }

            return total;
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            StringBuilder b = new StringBuilder();
            b.AppendFormat("CartId = {0}\n", base.id);
            b.AppendLine("Content:");
            foreach (var item in  Reservations)
            {
                b.Append("\t");
                b.Append(item);
                b.AppendLine();
            }
            return b.ToString();
        }
    }
}
