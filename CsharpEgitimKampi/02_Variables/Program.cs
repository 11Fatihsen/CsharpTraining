using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number= 0.15;
            //Console.WriteLine(number);
            double number1, number2;
            number1 = 12.86;
            number2 = 10;

            double total1 = number1 + number2;
            Console.WriteLine(total1);
            #endregion
            #region Char Değişkenler
            char symbol = 'A';
            Console.WriteLine(symbol);
            #endregion
            #region String Veri Girişi
            //string passengerName, passengerSurname;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine("Yolcu: " + passengerName +" "+ passengerSurname);
            //Console.WriteLine();
            #endregion
            #region Int Veri Girişi
            int FlightNumber;
            Console.Write("Uçuş Numarasını giriniz: ");
            FlightNumber=int.Parse(Console.ReadLine());
            Console.WriteLine(FlightNumber);
            #endregion
            #region Double Veri Girişi
            double bagWeight;
            Console.Write("Bagaj ağırlığınızı giriniz: ");
            bagWeight = double.Parse(Console.ReadLine());
            Console.WriteLine(bagWeight);
            #endregion
            #region Karakter Veri Girişi
            char gender;
            Console.WriteLine("Cinsiyer Giriniz: ");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine(gender);
            #endregion
            Console.ReadLine();
        }
    }
}
