using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace hotel
{
    public class AbstractUser:Utils.Entity
    {
        public AbstractUser()
        {
            
        }
        public String FirstName
        {
            get
            {
                return _firstName.Value;
            }
            private set { _firstName.Value = value; }
        }
        public String MiddledName
        {
            get
            {
                return _middledName.Value;
            }
            private set { _middledName.Value = value; }
        }
        public String LastName
        {
            get
            {
                return _lastName.Value;
            }
            private set { _lastName.Value = value; }
        }
        public String Login
        {
            get
            {
                return _login.Value;
            }
            private set { _login.Value = value; }
        }
        public int PasswordHash { get; private set; }
        protected Hotel _hotel { get; private set; }

        public AbstractUser (Guid id , String fname, String mname, String lname, 
            string login, int hash, Hotel hotel) : base( id )
        {
            FirstName = fname;
            MiddledName = mname;
            LastName = lname;
            _hotel = hotel;
            Login = login;
            PasswordHash = hash;
        }

        private Utils.NonEmptyString _firstName = new NonEmptyString("FirstName");
        private Utils.NonEmptyString _middledName = new NonEmptyString("MiddledName");
        private Utils.NonEmptyString _lastName = new NonEmptyString("LastName");
        private Utils.NonEmptyString _login = new NonEmptyString("Login");
    }
}
