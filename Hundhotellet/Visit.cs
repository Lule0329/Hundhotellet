using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Visit
    {
        public DateTime dropoffTime;
        public DateTime pickupTime;

        public Visit(DateTime dot, DateTime put)
        {
            dropoffTime = dot;
            pickupTime = put;
        }
    }
}
