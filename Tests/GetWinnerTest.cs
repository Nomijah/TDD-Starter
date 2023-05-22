using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class GetWinnerTest
    {
        [Test]
        public void GivenAListOfStringsComputeWinner()
        {
            // Given a list of strings
            List<string> results = new List<string>()
            {
            "Yatas Del Lana 3 5 3 5 7 2 3 0 10 4 3",
            "Eve Stojbs 3 7 3 3 9 1 6 4 2 3 1 0"
            };

            // When the list is iterated 
            Tuple<string, int> winner = GetWinner.CalculateWinner(results);

            // Expect Yatas to be the winner
            Tuple<string, int> expectedWinner = new Tuple<string, int>("Yatas Del Lana", 45);
            Assert.That(winner, Is.EqualTo(expectedWinner));


        }
        [Test]
        public void GivenAListOfStringsComputeWinner2()
        {
            // Given a list of strings
            List<string> results = new List<string>()
            {
            "Yatas Del Lana 3 5 3 5 7 2 3 0 10 4 3",
            "Eve Stojbs 3 7 3 3 9 1 6 4 2 3 1 0"
            };

            // When the list is iterated 
            Tuple<string, int> winner = GetWinner.CalculateWinner2(results);

            // Expect Yatas to be the winner
            Tuple<string, int> expectedWinner = new Tuple<string, int>("Eve Stojbs", 57);
            Assert.That(winner, Is.EqualTo(expectedWinner));


        }

    }
}
