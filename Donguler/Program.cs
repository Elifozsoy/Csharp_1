using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "python kursu";
            string kurs2 = "yazılım geliştirme kampı";
            string kurs3 = "java kursu";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine("------");

            //array - dizi

            string[] kurslar = new string[] { "python kursu", 
                "yazılım geliştirme kampı", "java kursu" };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar. ('Kursları' tek tek dolaşır.)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("--sayfa sonu--");
        }
    }
}
