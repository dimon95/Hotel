using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Hotel:IVisitable
    {

        public Admin Sudo { get; private set; }
        public Requisites PayInfo
        {
            get { return _bankRequisites[_bankRequisites.Count - 1]; }
        }

        public Hotel()
        {
            Sudo = new Admin(Guid.NewGuid(), "Supervisor", "SS", "SS", "sudo", "1111".GetHashCode(),
                this, AccessLevel.Supervisor);
        }

        public bool CanReserve ( AbstractPlace place, DateTime date, int period )
        {
            foreach ( Reservation reserv in _resrvations )
            {
                if ( reserv.Place == place )
                {
                    DateTime tmp1 = reserv.StartDate;
                    DateTime tmp2 = date;

                    while ( tmp1 <= reserv.StartDate.AddDays( reserv.ReservationPeriod ) |
                           tmp2 <= tmp2.AddDays( period ) )
                    {
                        if ( tmp1 == tmp2 )
                            return false;

                        tmp1 = tmp1.AddDays( 1 );
                        tmp2 = tmp2.AddDays( 2 );
                    }
                }
            }

            return true;
        }
        public void AddReservation (Reservation r)
        {
            _resrvations.Add(r);
        }
        public void AddRoom ( Guid id, InfoDiscription info )
        {
            _rooms.Add( new Room(id, info) );
        }
        public void AddHall ( Guid id, InfoDiscription info )
        {
            _halls.Add( new Hall(id, info) );
        }
        public void AddClient ( Guid id, String fName, String lName, String name, string login, int hash, Hotel hotel )
        {
            _clients.Add( new Client(id, fName, lName, name, login, hash, this) );
        }
        public void AddAdmin ( Guid id, string fName, string lName, string name, string login, 
            int hash, Hotel hotel, AccessLevel access )
        {
            _admins.Add( new Admin( id, fName, lName, name, login, hash, this, access ) );
        }
        public void AddRquisites ( Requisites rq )
        {
            _bankRequisites.Add( rq );
        }
        public void RemoveRoom ( Guid id )
        {
            _rooms.Remove(_rooms.First(el => el.id == id));
        }
        public void RemoveHall ( Guid id )
        {
            _halls.Remove(_halls.First(el => el.id == id));
        }
        public void RemoveClient ( Guid id )
        {
            _clients.Remove(_clients.First(el => el.id == id));
        }
        public void RemoveAdmin ( Guid id )
        {
            _admins.Remove(_admins.First(el => el.id == id));
        }
        public void RemoveRquisites ( Requisites rq )
        {
            _bankRequisites.Remove( rq );
        }



        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }

        public override string ToString ()
        {
            var result = (
                       "Hotel:: \n Clients: \n"
                   );

            foreach ( var res in _clients )
            {
                result += " " + res + "\n";
            }

            result += " Admins: \n";

            foreach ( var res in _admins )
            {
                result += " " + res + "\n";
            }

            result += " Rooms: \n";

            foreach ( var res in _rooms )
            {
                result += " " + res + "\n";
            }

            result += " Halls: \n";

            foreach ( var res in _halls )
            {
                result += " " + res + "\n";
            }

            return result;
        }


        private List<Room> _rooms = new List<Room>();
        private List<Hall> _halls = new List<Hall>();
        private List<Client> _clients = new List<Client>();
        private List<Admin> _admins = new List<Admin>();
        private List<Requisites> _bankRequisites = new List<Requisites>();
        private List<Reservation> _resrvations = new List<Reservation>();
    }
}
