using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Example;
using NUnit.Framework.Interfaces;

namespace Tests
{
    public class TestReadFile
    {
        [Test]
        public void ReadFileTest()
        {
            // Given a path
            string filePath = "C:\\Users\\pette\\Source\\Repos\\csharp\\Example\\TestData.txt";
            // When the file is read
            List<string> lines = FileReader.ReadFile(filePath);
            // Expect the returned lines contain a name and a series of numbers
            List<string> expected = new List<string>() 
            {
            "Yatas Del Lana 3 5 3 5 7 2 3 0 10 4 3",
            "Eve Stojbs 3 7 3 3 9 1 6 4 2 3 1 0"
            };
            Assert.That(lines, Is.EqualTo(expected));
        }

    }
}
