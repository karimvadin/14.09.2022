using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lang = "it"; 
            switch (lang)
            {
                case "en":
                    Console.WriteLine("Hello world!");
                    break;
                case "ru":
                    Console.WriteLine("Привет мир!");
                    break;
                case "jpn":
                    Console.WriteLine("こんにちは世界!");
                    break;
                case "it":
                    Console.WriteLine("Ciao mondo!");
                    break;
                default:
                    Console.WriteLine("Локализация не найдена!");
                    break;
            }
        }
    }
}
