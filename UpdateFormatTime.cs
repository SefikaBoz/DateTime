# DateTime

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uçuş tarihi (gün ay yıl) ve saati sırasıyla giriniz(saat dakika saniye)...");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime departureDate = new DateTime(year, month, day);
            Console.WriteLine("Departure Date: " + departureDate);

            string departureHour = Console.ReadLine();
            Console.WriteLine("Departure Hour: " + departureHour);

            Console.WriteLine("Varış saati nedir ? (saat, dakika, saniye olarak sıralı girin..)");

            string arrivalHour = Console.ReadLine();     

            char seperator = ':';

            string[] splitDeparture = departureHour.Split(seperator);
            int depHour = Convert.ToInt32(splitDeparture[0]);

            string [] splitArrival = arrivalHour.Split(seperator);
            int arHour = Convert.ToInt32(splitArrival[0]);

            DateTime arrivalDate;

            if(depHour > arHour)
            {
                arrivalDate = departureDate.AddDays(1);
            }
            else
            {
                arrivalDate = departureDate;
            }

            Console.WriteLine("ArrivalDate : " + arrivalDate);
       

            Console.ReadLine();
        }
        public void Calculate()
        {

        }
    }
}
