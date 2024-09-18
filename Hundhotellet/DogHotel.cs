using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class DogHotel
    {
        public Dog[] dogArray = new Dog[9];
        double costPerNight = 300;
        Dictionary<int, Booking> bookingDict = new Dictionary<int, Booking>();

        public void SetDog(int cageNumber, Dog dog)
        {
            dogArray[cageNumber] = dog;
        }

        public Dog GetDog(int cageNumber)
        {
            return null;
        }

        public void PrintFeedingSchedule()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------ Feeding ------------");
            for (int i = 0; i < dogArray.Length - 1; i++)
            {
                string temp = "";

                if (dogArray[i] != null)
                {
                    temp = $"Crate {i}: {string.Join(" | ", dogArray[i].mealList)}";
                }
                else if (dogArray[i] == null)
                {
                    temp = $"Crate {i}: Empty";
                }
                
                Console.WriteLine(temp);
            }
        }

        void PrintPickups()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------ Pickups ------------");
            for (int i = 0; i < dogArray.Length - 1; i++)
            {
                string temp = "";

                if (dogArray[i] != null)
                {
                    temp = $"Crate {i}: {dogArray[i].name} | " +
                        $"dropoff: {dogArray[i].visit.dropoffTime.Hour}.00 | " +
                        $"pickup: {dogArray[i].visit.pickupTime.Hour}.00";
                }
                else if (dogArray[i] == null)
                {
                    temp = $"Crate {i}: null";
                } 

                Console.WriteLine(temp);
            }
        }

        void PrintInvoice(int cageNumber)
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------ Fakturor ------------");

            if (dogArray[cageNumber] != null)
            {
                Dog d = dogArray[cageNumber];
                Console.WriteLine($"Dog: {d.name} | " +
                    $"ID: {d.chipNumber} | " +
                    $"Time: {d.visit.dropoffTime.Hour}.00 to {d.visit.pickupTime.Hour}.00 | " +
                    $"Owner: {d.owner.firstName} {d.owner.lastName} | " +
                    $"Adress: {d.owner.adress.stad}, {d.owner.adress.gatuAdress}, {d.owner.adress.postNummer} | " +
                    $"Final Cost: {(costPerNight * (d.visit.pickupTime.Hour - d.visit.dropoffTime.Hour)) / 2}");
            }
        }
        
        public void PrintInfo()
        {
            for (int i = 0; i < dogArray.Length - 1; i++)
            {
                if (dogArray[i] != null)
                {
                    Console.WriteLine($"Dog: {dogArray[i].name}  | " +
                        $"ID: {dogArray[i].chipNumber} | " +
                        $"Owner: {dogArray[i].owner.firstName} {dogArray[i].owner.lastName} | " +
                        $"Adress: {dogArray[i].owner.adress.stad}, {dogArray[i].owner.adress.gatuAdress}, " +
                        $"{dogArray[i].owner.adress.postNummer}");
                }
            }

            PrintFeedingSchedule();
            PrintPickups();
            PrintInvoice(2);
        }
    }
}
