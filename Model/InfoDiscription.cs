using System;
using Utils;

namespace hotel
{
    public class InfoDiscription : Entity
    {
        public string Discription{get;set;}
        public double Price{get;set;}
        public int PersonSize{get;set;}

        public InfoDiscription()
        {
            
        }

        public InfoDiscription ( Guid id,string disk, int price, int personSize ) :base(id)
        {
            Discription = disk;
            Price = price;
            PersonSize = personSize;
        }

        public override string ToString ()
        {
            return string.Format(
                       "Info::  Price:{0}, PersonSize:{1}, Discription:{2}",
                        Price, PersonSize,Discription 
                   );
        }
       
    }
}
