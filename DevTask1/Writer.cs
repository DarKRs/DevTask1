using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask1
{
    public class Writer
    {
        string path;
        Dictionary<string, int> wordCount;


        Writer(string path)
        {
            this.path = path;
            wordCount = new Dictionary<string, int>();
        }
        
        

    }
}
