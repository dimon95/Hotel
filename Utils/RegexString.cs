/* (C) 2014-2016, Sergei Zaychenko, NURE, Kharkiv, Ukraine */

using System;
using System.Text.RegularExpressions;

namespace Utils
{
    public class RegexString : NonEmptyString
    {
        public RegexString ( string name, string pattern)
            :   base( name )
        {
            this._pattern = pattern;
        }

        protected override void CheckValue ( string value )
        {
            base.CheckValue( value );
            if ( ! Regex.IsMatch( value, _pattern ) )
                throw new ArgumentException( "Invalid format", ParamName );
        }

        private readonly string _pattern;
    }
}
