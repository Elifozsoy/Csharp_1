using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new string[] { "elif", "ayşe", "fatma" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            // isimler[3] = "zeynep"; //hata
            // Console.WriteLine(isimler[3]); //hata

            //dizilere sonradan data eklenemediği için koleksiyonlar kullanılır

            List<string> isimler2 = new List<string> { "elif", "ayşe", "fatma" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("zeynep");
            Console.WriteLine(isimler2[3]);
        }
    }
}
