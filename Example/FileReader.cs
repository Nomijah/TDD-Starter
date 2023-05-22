using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example
{
    public class FileReader
    {
        public static List<string> ReadFile(string filePath)
        {
            List<String> lines = File.ReadAllLines(filePath).ToList();
            return lines;
        }
    }
}
