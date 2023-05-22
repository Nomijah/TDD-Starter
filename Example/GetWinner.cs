namespace Tests
{
    public class GetWinner
    {
        public static Tuple<string, int> CalculateWinner(List<string> results)
        {
            string winner = "";
            int winnerResult = 0;

            foreach (var player in results)
            {
                int totalScore = 0;
                string name = "";

                string[] strings = player.Split(" ");
                
                foreach (string s in strings)
                {
                    
                    if (Int32.TryParse(s, out int score)) 
                    { 
                        totalScore += score;
                    }
                    else
                    {
                        name += s + " ";
                    }
                }
                name = name.Trim();

                if(totalScore > winnerResult)
                {
                    winnerResult = totalScore;
                    winner = name;
                }

            }
            return Tuple.Create(winner, winnerResult);

        }
        public static Tuple<string, int> CalculateWinner2(List<string> results)
        {
            string winner = "";
            int winnerResult = 0;

            foreach (var player in results)
            {
                int totalScore = 0;
                string name = "";
                int throwNumber = 1;
                int frameScore = 0;

                string[] strings = player.Split(" ");

                foreach (string s in strings)
                {

                    if (Int32.TryParse(s, out int score))
                    {
                        if (throwNumber == 1 && score == 10)
                        {
                            totalScore += 20;
                        }
                        else if (throwNumber == 1)
                        {
                            frameScore = score;
                            throwNumber++;
                        }
                        else
                        {
                            frameScore += score;
                            if (frameScore == 10)
                            {
                                totalScore += 15;
                            }
                            else
                            {
                                totalScore += frameScore;
                                
                            }
                            throwNumber = 1;
                        }

                    }
                    else
                    {
                        name += s + " ";
                    }
                }
                name = name.Trim();

                if (totalScore > winnerResult)
                {
                    winnerResult = totalScore;
                    winner = name;
                }

            }
            return Tuple.Create(winner, winnerResult);

        }
    }
}