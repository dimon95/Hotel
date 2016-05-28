using System;
using Utils;

namespace hotel
{
    public class Reservation : Entity,IVisitable
    {
        public Guid PlaceId { get { return Place.id; } }

        public virtual AbstractPlace Place
        {
            get { return _place.Value; }
            private set{ _place.Value = value; }
        }

        public DateTime StartDate
        {
            get;
            set;
        }
        public int ReservationPeriod
        {
            get;
            set;
        }

        public Reservation()
        {
            
        }
        public Reservation ( Guid id, AbstractPlace place, DateTime date, int period )
            :base(id)
        {
            Place = place;
            StartDate = date;
            ReservationPeriod = period;
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            return string.Format(
                       "Reservation:: Place:{0} StartDate:{1} Period(Days):{2}",
                       Place, StartDate, ReservationPeriod
                   );
        }
        private RequiredProperty<AbstractPlace> _place = new RequiredProperty<AbstractPlace>("place");

    }
}
