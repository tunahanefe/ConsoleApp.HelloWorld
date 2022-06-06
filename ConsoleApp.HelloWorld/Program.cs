using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu HelloWorld uygulaması, GitHub test projesidir.");
            Console.Write("Mesajınız : ");
            string msg = Console.ReadLine();
            Console.WriteLine($"İletmiş olduğunuz mesaj : {msg}");

            Model mdl = new Model();
            Console.Write("Adınız : ");
            mdl.Adi = Console.ReadLine();
            Console.Write("Soyadınız : ");
            mdl.Soyadi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(mdl.IsimYazdir());
            Console.ReadKey();
        }
    }
}
