using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    ParseAndUpdate(line);
                }
            }
            var sortedDict = from entry in wordCount orderby entry.Value descending select entry;
        }

        private void ParseAndUpdate(string line)
        {
            Regex regex = new Regex(@"\W");
            string toParse = regex.Replace(line.ToLower(), " ");
            string[] words = toParse.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach(var word in words)
            {
                if(!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 1);
                }
                else
                {
                    wordCount[word]++;
                }
            }
            return;
        }
    }
}
