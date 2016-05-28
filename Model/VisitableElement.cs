using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    interface IVisitable
    {
        void Visit ( IVisitor visitor );
    }
}
