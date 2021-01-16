using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.4;
            bool girisYapilmisMi = false;

            if (girisYapilmisMi)
            {
                Console.WriteLine("Girş yapıldı.");
            }
            else Console.WriteLine("Giriş Yapılmadı.");
            Console.WriteLine(kategoriEtiketi);

            double dolarDün = 7.35;
            double dolarBugün = 7.45;

            if (dolarDün>dolarBugün)
            {
                Console.WriteLine("Aşağı yönde ok");
            }
            else if (dolarDün<dolarBugün)
            {
                Console.WriteLine("Yukarı yönde ok");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
        }
    }
}
