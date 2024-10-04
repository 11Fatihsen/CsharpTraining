using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Hello World");
            Console.WriteLine("SSS");
            #endregion

            #region String Değişkenler
            //string 
            //Değişken_türü değişken_adı;

            string name;
            name = "Murat";
            Console.WriteLine(name);

            string custumerName;
            string custumerSurname;
            string custumerPhone;
            string custumerEmail, district, city;

            custumerName = "Ali";
            custumerSurname ="Çınar";
            custumerPhone = "+90 500 400 30 20";
            custumerEmail ="deneme@gmail.com";
            district = "Üsküdar";
            city = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Müşteri: " + custumerName+ " "+ custumerSurname);
            Console.WriteLine("İletişim: " + custumerPhone);
            Console.WriteLine("Email Adresi: "+ custumerEmail);
            Console.WriteLine("Adres: "+ district + "/" + city);
            Console.WriteLine("---------------------------------------");
            #endregion

            #region İnt Değişkenler
            int number = 11;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int friesPrice = 50;
            int waterPrice = 15;

   
            Console.WriteLine();
            Console.WriteLine("-----------**** Menü ****----------------");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL" );
            Console.WriteLine("-----Patates: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice+"TL");
            Console.WriteLine("---------------------------------------");

            #endregion

            Console.ReadLine();


        }
    }
}
