/* (C) 2014-2016, Sergei Zaychenko, NURE, Kharkiv, Ukraine */

using System;
using Utils;

namespace Utils
{
    public class RequiredProperty< T > : AbstractProperty
    {
        public T Value {
            get { return _value; }
            set {
                if ( value == null )
                    throw new ArgumentNullException( ParamName );

                _value = value;
            }
        }

        public RequiredProperty ( string paramName )
            :   base( paramName )
        {
        }

        private T _value;
    }
}
