using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Client:AbstractUser, IVisitable
    {

        public virtual ICollection<Order> Orders { get; set; }

        public Client(Guid id , String fName, String lName, String name, string login, int hash, Hotel hotel ) 
            : base( id, fName, lName, name,  login, hash, hotel)
        {
            Orders = new List<Order>();
            _cart.Value = new Cart();
        }

        public Client()
        {
            
        }
        public void PayCart()
        {
            Payment p = new Payment(Guid.NewGuid(), _hotel.PayInfo, _cart.Value.GetTotalPrice());
            p.Pay();

            if ( p.IsCompleted )
            {
                Orders.Add(new Order(Guid.NewGuid(), p, _cart.Value.Reservations));

                foreach (Reservation r in _cart.Value.Reservations)
                    _hotel.AddReservation( r );

                _cart.Value.Clear();
            }
        }

        public void AddReservation ( Reservation r )
        {
            if ( !_hotel.CanReserve( r.Place, r.StartDate, r.ReservationPeriod ) )
                return;


            _cart.Value.AddReservation(r);
        }

        public void RemoveReservation ( Reservation r )
        {
            _cart.Value.RemoveReservation(r);
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {

            var result = string.Format(
                       "Client: LastName = {0} has orders:" ,
                       LastName
                   );

            foreach ( var res in Orders )
            {
                result += " " + res + "\n";
            }

            return result;
        }

        private Utils.RequiredProperty<Cart> _cart = new Utils.RequiredProperty<Cart>("cart");
    }
}
