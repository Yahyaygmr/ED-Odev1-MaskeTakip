using System;

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
