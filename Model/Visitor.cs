using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public interface IVisitor
    {
        void Visit (Hotel h);
        void Visit ( Admin a );
        void Visit ( Client c );
        void Visit ( Cart cart );
        void Visit ( Reservation res);
        void Visit ( Order order );
        void Visit ( Payment pay );
        void Visit ( Hall hall);
        void Visit ( Room r );
    }
}
