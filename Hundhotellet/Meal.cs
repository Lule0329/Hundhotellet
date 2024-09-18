using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Meal
    {
        public int hourOfDay;
        public string foodType;
        public string amount;

        public Meal(int hr, string ft, string am) 
        { 
            hourOfDay = hr;
            foodType = ft;
            amount = am;
        }

        public override string ToString()
        {
            return $"{amount} of {foodType} kl {hourOfDay}";
        }
    }
}
