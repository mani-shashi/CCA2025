namespace PracticeQuestions
{
    public class RockPaperScissors
    {
        public void Play()
        {

            Console.WriteLine("\nEnter choice: rock, paper, scissors  ");
            Console.Write("Player A choice: ");
            string? input1 = Console.ReadLine();
            Console.Write("Player B choice: ");
            string? input2 = Console.ReadLine();
            GetWinner(input1, input2);
            Console.WriteLine("Enter exit anytime to exit the game");
        }

        /// <summary>
        /// Method to find winner of the Rock paper scissor game
        /// </summary>
        /// <param name="playerA">Player A input as String</param>
        /// <param name="playerB">Player B input as String</param>

        public void GetWinner(string playerA , string playerB)
        {
            playerA = playerA.ToLower();
            playerB = playerB.ToLower();

            if(playerA == "exit" || playerB == "exit")
            {
                Console.WriteLine("Game has beeen terminated.");
                return;
            }
            //To trminate the game anytime 

            string GameRemarks = "";

            if (playerA == playerB)
            {
                GameRemarks = "Tie ! Play Again";
            } 
            else if (playerA == "rock")
            {
                if (playerB == "paper")
                {
                    GameRemarks = "Result : player B Wins";
                }else if (playerB == "scissors")
                {
                     GameRemarks = "Result : player A Wins";
                } else
                {
                    GameRemarks = "Invalid Input!";
                }
            } 
            else if (playerA == "paper")
            {
                if (playerB == "rock")
                {
                    GameRemarks = "Result : player A Wins";
                }else if (playerB == "scissors")
                {
                    GameRemarks = "Result : player B Wins";
                } else
                {
                    GameRemarks = "Invalid Input!";
                    
                }
            }
            else if (playerA == "scissors")
            {
                if (playerB == "paper")
                {
                    GameRemarks = "Result : player A Wins";
                }else if (playerB == "rock")
                {
                    GameRemarks = "Result : player B Wins";
                } else
                {
                    GameRemarks = "Invalid Input!";
                    Play();
                }
            }

            Console.WriteLine(GameRemarks);
            Console.WriteLine("Enter exit anytime to exit the game");
            Play();

        }
    }
}