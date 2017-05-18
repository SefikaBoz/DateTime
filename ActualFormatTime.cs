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
          
            string departureHour = Console.ReadLine();
          
            Console.WriteLine("Varış saati nedir ? (saat, dakika, saniye olarak sıralı girin..)");

            string arrivalHour = Console.ReadLine();     

            char seperator = ':';

            string[] splitDeparture = departureHour.Split(seperator);
            int newDepartureHour = Convert.ToInt32(splitDeparture[0]);

            string [] splitArrival = arrivalHour.Split(seperator);
            int newArrivalHour = Convert.ToInt32(splitArrival[0]);
            int newArrivalMinute = Convert.ToInt32(splitArrival[1]);
            int newArrivalSecond = Convert.ToInt32(splitArrival[2]);

            DateTime arrivalDate;

            if(newDepartureHour > newArrivalHour)
            {
                arrivalDate = departureDate.Add(new TimeSpan(1, newArrivalHour, newArrivalMinute, newArrivalSecond));                      
            }
            else
            {
                arrivalDate = departureDate;
            }

            Console.WriteLine("ArrivalDate : " + arrivalDate);
       

            Console.ReadLine();
        }
      
    }
}
