using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Address
    {
        public string gatuAdress;
        public string stad;
        public string postNummer;

        public Address(string ga, string s, string pn)
        {
            gatuAdress = ga;
            stad = s;
            postNummer = pn;
        }
    }
}
