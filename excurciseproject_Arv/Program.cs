using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excurciseproject_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Property MyProperty = new Property("Sisjöbäckens väg 4: ", 4, 20000000);

            Apartment MyApartment = new Apartment(3, 60.35, "Bangårdsgatan 7", 3, 250000);

            string PropertyAdress = MyProperty.GetAddress();
            int NumberOfApartments = MyProperty.GetApartments();
            double PropertyPris = MyProperty.GetPris();

            string ApartmentAdress = MyApartment.GetAddress();
            int ApartmentRooms = MyApartment.GetRoom();
            double ApartmentKVM = MyApartment.GetKvadratMeter();
            double ApartmentPris = MyApartment.GetPris();

            Console.WriteLine("Välkommen till Felipes Mäklare!");

            Console.WriteLine("Om du är intresserad utav Lägenhetsbyggnaden tryck 1\n" +
                "Om du är intresserad utav lägenheten och vill veta mer info tryck 2!: ");
            string input1 = Console.ReadLine();            

            if(input1 == "1")
            {

                Console.WriteLine("Lägenhetsbyggnadens Adress är: " + PropertyAdress + " Det finns " + NumberOfApartments + " lägenheter i byggnaden " + "Priset för byggnaden är" + PropertyPris + "KR");
                Console.WriteLine("Om du är intresserad utav lägenheten tryck 1 annars tryck 3 för att avsluta:  ");
                string input3 = Console.ReadLine();
                if (input3 == "1")
                {
                    Console.WriteLine("GRATTIS!! Du har köpt Byggnaden för hela " + PropertyPris + "KR" + "Riktigt bra investering!");
                }
                else if(input3 == "3")
                {
                    Environment.Exit(0);
                }
                
             }
            else if( input1 == "2")
            {
                
                Console.WriteLine("Lägenhetens Adressen är: " + ApartmentAdress + ", " + "Antal rum i lägemnheten: " + ApartmentRooms + ", " + "Antal KVM: " + ApartmentKVM);

                Console.WriteLine("Om du är intresserad utav lägenheten tryck 1 annars tryck 3 för att avsluta: ");
                string input4 = Console.ReadLine();
                if(input4 == "1")
                {
                    Console.WriteLine("GRATTIS!! Du har köpt Lägenheten för " + PropertyPris + "KR." + " Hoppas att du kommer trivas");

                }
                else if( input4 == "3")
                {
                    Environment.Exit(0);
                }
            }




        }
    }
}
