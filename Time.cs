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


            Console.WriteLine("uçuş tarihi (gün ay yıl) ve saati sırasıyla giriniz(saat dakika saniye)...");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yolculuk suresi ne kadar ? (Gün , saat, dakika, saniye olarak sıralı girin..)");
            int arrivalDay = Convert.ToInt32(Console.ReadLine());
            int aHour = Convert.ToInt32(Console.ReadLine());
            int aMinute = Convert.ToInt32(Console.ReadLine());
            int aSecond = Convert.ToInt32(Console.ReadLine());

            DateTime dateTimeObj = new DateTime(year, month, day, hour, minute, second);
            Console.WriteLine(dateTimeObj);
          
            TimeSpan dif = new TimeSpan(arrivalDay, aHour, aMinute, aSecond);
            DateTime newDateTimeObj = dateTimeObj + dif;

            Console.WriteLine(newDateTimeObj);
            
            Console.ReadLine();
        }
    }
}
