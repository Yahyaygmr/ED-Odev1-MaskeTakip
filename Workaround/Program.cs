using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SelamVer("engin");
            SelamVer("ahmet");
            SelamVer();

            int sonuc = Topla(3, 5);
            Topla();


            //Diziler Arrays


            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = ogrenci1;
            ogrenciler[1] = ogrenci2;
            ogrenciler[2] = ogrenci3;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach (string sehir in sehirler2) 
            {
                Console.WriteLine("foreach" + sehir);
            }

            //

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("Adana");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            Person person1 = new Person();
            person1.FirstName = "Yahya";
            person1.LasttName = "Yağmur";
            person1.DateOfBirthYear = 1983;
            person1.NationalIdentity = 12345678910;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);




            Vatandas vatandas1 = new Vatandas();

            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + " " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 7)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
