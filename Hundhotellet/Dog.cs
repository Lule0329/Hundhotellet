using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Dog
    {
        public string name;
        public string chipNumber;
        public Owner owner;
        public List<Meal> mealList;

        public Dog(string n, string cn, Owner on) 
        { 
            name = n;
            chipNumber = cn;
            owner = on;
        }

        public void AddMeal(Meal meal)
        {

        }
    }
}
