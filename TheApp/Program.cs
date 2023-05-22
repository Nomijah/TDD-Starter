namespace TheApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var winner = GetWinner.CalculateWinner(FileReader.ReadFile("C:\\Users\\pette\\Desktop\\series01.txt"));
            Console.WriteLine(winner.Item1 + " " + winner.Item2);
        }
    }
}