/* (C) 2014-2016, Sergei Zaychenko, NURE, Kharkiv, Ukraine */

using System;

namespace Utils
{
    public abstract class AbstractProperty
    {
        public string ParamName { get; private set; }

        protected AbstractProperty ( string paramName )
        {
            if ( paramName == null )
                throw new ArgumentNullException( "paramName" );

            this.ParamName = paramName;
        }
    }
}
