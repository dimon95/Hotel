using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public enum AccessLevel { Staff, Modarator, Master, Supervisor };

    public class Admin : AbstractUser, IVisitable
    {

        public virtual AccessLevel Access { get; private set; }

        public Admin ( Guid id, string fName, string lName, string name, string login, int hash, Hotel hotel, AccessLevel access )
            :base(id, fName, lName, name, login, hash, hotel)
        {
            Access = access;
        }

        public void AddAdmin ( Guid id, string fName, string lname, string mName, string login, int hash , Hotel hotel, AccessLevel access)
        {
            if ( Access < access || Access < AccessLevel.Master )
                throw new ArgumentException();

            _hotel.AddAdmin( id, fName, lname, mName, login, hash, hotel, access );
        }

        public void RemoveAdmin ( Guid id )
        {
            _hotel.RemoveAdmin( id );
        }

        public Admin()
        {
            
        }

        public override string ToString ()
        {
            return string.Format(
                       "Admin: LastName = {0} AccessLV = {1}",
                       LastName,
                       Access
                   );
        }

        public void Visit ( IVisitor visitor )
        {
            visitor.Visit( this );
        }
    }
}
