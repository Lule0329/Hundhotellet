using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Booking
    {
        public Dog dog;
        public int cageNumber;
        public DateTime dropOffTime;
        public DateTime PickUpTime;

        public Booking(Dog dog, int cageNumber, DateTime dropOffTime, DateTime pickUpTime)
        {
            this.dog = dog;
            this.cageNumber = cageNumber;
            this.dropOffTime = dropOffTime;
            this.PickUpTime = pickUpTime;
        }
    }
}
