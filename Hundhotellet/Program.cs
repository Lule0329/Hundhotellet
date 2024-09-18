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
            DateTime date1 = new DateTime(2020, 5, 10, 10, 0, 0);
            DateTime date2 = new DateTime(2020, 5, 10, 15, 0, 0);
            
            Address testAddress1 = new Address("gata1", "stad1", "25555");
            Address testAddress2 = new Address("gata2", "stad2", "55555");
            Owner testOwner1 = new Owner("Olle", "Ollsson", testAddress1);
            Owner testOwner2 = new Owner("Bert", "Bertsson", testAddress2);
            Meal testMeal1 = new Meal(7, "Meal1", "10kg");
            Meal testMeal2 = new Meal(9, "Meal2", "20kg");
            Visit visit1 = new Visit(date1, date2);
            Visit visit2 = new Visit(date2, date1);
            Dog testDog1 = new Dog("fido", "123456", testOwner1, visit1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2, visit2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);
            testDog1.AddMeal(testMeal1);
            testDog2.AddMeal(testMeal2);
            testDog2.AddMeal(testMeal1);
        }
    }
}
