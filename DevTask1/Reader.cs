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

        public Reader(string path)
        {
            this.path = path;
            wordCount = new Dictionary<string, int>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public async void Read()
        {
            Encoding win1251 = Encoding.GetEncoding(1251);
            string str;
            using (var reader = new StreamReader(@path, win1251))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
