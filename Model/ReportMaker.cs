using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class YaVisitor : IVisitor
    {
        public void Visit ( Client c )
        {
            Console.WriteLine(c);
        }

        public void Visit ( Reservation res )
        {
            Console.WriteLine(res);
        }

        public void Visit ( Payment pay )
        {
            Console.WriteLine(pay);
        }

        public void Visit ( Room r )
        {
            Console.WriteLine(r);
        }

        public void Visit ( Hall hall )
        {
            Console.WriteLine(hall);
        }

        public void Visit ( Order order )
        {
            throw new NotImplementedException();
        }

        public void Visit ( Cart cart )
        {
            throw new NotImplementedException();
        }

        public void Visit ( Admin a )
        {
            throw new NotImplementedException();
        }

        public void Visit ( Hotel h )
        {
            Console.WriteLine(h);
        }
    }
}
