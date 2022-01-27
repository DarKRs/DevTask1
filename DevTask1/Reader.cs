using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask1
{
    class Reader
    {
        string path;
        Dictionary<string,int> wordCount;

        Reader(string path)
        {
            this.path = path;
            wordCount = new Dictionary<string, int>();
        }

        public void Read()
        {
            Encoding win1251 = Encoding.GetEncoding(1251);
            using (var reader = new StreamReader(path, win1251))
            {
                 str =  reader.ReadToEndAsync();
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding..GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
    }
}
