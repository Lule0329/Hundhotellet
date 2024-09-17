using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Owner
    {
        public string firstName;
        public string lastName;
        public Address adress;

        public Owner(string fn, string ln, Address ad)
        {
            firstName = fn;
            lastName = ln;
            adress = ad;
        }
    }
}
