/* (C) 2014-2016, Sergei Zaychenko, NURE, Kharkiv, Ukraine */

using System;
using Utils;

namespace Utils
{
    public class RangeProperty< T > : AbstractProperty
        where T : IComparable< T >
    {
        public T Value
        {
            get { return _currentValue; }

            set
            {
                CheckValue( value );
                _currentValue = value;
            }
        }

        public RangeProperty ( string paramName, T minValue, bool includingMin, T maxValue, bool includingMax )
            :   base( paramName )
        {
            this._minValue = minValue;
            this._includingMin = includingMin;
            this._maxValue = maxValue;
            this._includingMax = includingMax;
        }


        protected void CheckValue ( T value )
        {
            if ( _includingMin && value.CompareTo( _minValue ) < 0 ||
                ! _includingMin && value.CompareTo( _minValue ) <= 0 )
            {
                throw new ArgumentException( "Minimal range violated", ParamName );
            }

            if ( _includingMax && value.CompareTo( _maxValue ) > 0 ||
                 ! _includingMax && value.CompareTo( _maxValue ) >= 0 )
            {
                throw new ArgumentException( "Maximal range violated", ParamName );
            }
        }

        private T _currentValue;
        private readonly T _minValue, _maxValue;
        private readonly bool _includingMin, _includingMax;
    }
}
