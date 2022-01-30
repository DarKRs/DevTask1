using System;
using System.Text;

namespace DevTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.WriteLine("Введите путь до входного файла:");

            string path = Console.ReadLine();
            Reader r = new(path);
            r.Read();
            Console.ReadKey();
        }
    }
}
