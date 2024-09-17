using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
        }

        static void AddTestData(DogHotel dogHotel)
        {
            Address testAddress1 = new Address("gata1", "stad1", "25555");
            Address testAddress2 = new Address("gata2", "stad2", "55555");
            Owner testOwner1 = new Owner("Olle", "Ollsson", testAddress1);
            Owner testOwner2 = new Owner("Bert", "Bertsson", testAddress2);
            Dog testDog1 = new Dog("fido", "123456", testOwner1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);   
        }
    }
}
