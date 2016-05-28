/* (C) 2014-2016, Sergei Zaychenko, NURE, Kharkiv, Ukraine */

using System;

namespace Utils
{
    public abstract class Entity
    {
        public Guid id { get; private set; }

        public long DatabaseId { get; set; }

        protected Entity () {}

        protected Entity ( Guid id )
        {
            if ( id == null )
                throw new ArgumentNullException( "id" );

            this.id = id;
        }

        public override bool Equals ( object obj )
        {
            if ( this == obj )
                return true;

            if ( obj == null || GetType() != obj.GetType() )
                return false;

            var otherEntity = ( Entity ) obj ;
            return id == otherEntity.id;
        }

        public override int GetHashCode ()
        {
            return id.GetHashCode();
        }
    }
}
