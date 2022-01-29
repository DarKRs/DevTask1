using System;

namespace DevTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до входного файла:");
            string path = Console.ReadLine();
            Reader r = new(path);
            r.Read();
            Console.ReadKey();
        }
    }
}
