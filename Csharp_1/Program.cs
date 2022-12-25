using System;

namespace Csharp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type saftely: tip güvenliği //Do not repeat yourself.

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //true or false
            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artmış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi); //print
        }
    }
}
