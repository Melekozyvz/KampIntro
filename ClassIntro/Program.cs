using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs javaKursu = new Kurs("Java","Melek", 0);
            javaKursu.kursBilgileriYazdir();
        }
    }
    class Kurs
    {
        public Kurs(string kursAdi,string egitmen,int izlenmeOrani)
        {
            this.kursAdi = kursAdi;
            this.kursEgitmeni = egitmen;
            this.izlenmeOrani = izlenmeOrani;
        }
        public void kursBilgileriYazdir()
        {
            Console.WriteLine("kurs adı:"+kursAdi);
            Console.WriteLine("egitmen adı:" + kursEgitmeni);
            Console.WriteLine("izlenme oranı:" + izlenmeOrani);
        }
        public string kursAdi { get; set; }
        public string kursEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
