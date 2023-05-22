using Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var winner = GetWinner.CalculateWinner(FileReader.ReadFile("C:\\Users\\pette\\Desktop\\series01.txt"));
            Console.WriteLine(winner.Item1 + " " + winner.Item2);
            winner = GetWinner.CalculateWinner2(FileReader.ReadFile("C:\\Users\\pette\\Source\\Repos\\csharp\\Example\\Stage2Data.txt"));
            Console.WriteLine(winner.Item1 + " " + winner.Item2);
        }
    }
}
