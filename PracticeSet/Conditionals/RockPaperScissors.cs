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

        public void GetWinner(string playerA , string playerB)
        {
            playerA = playerA.ToLower();
            playerB = playerB.ToLower();
            if(playerA == "exit" || playerB == "exit")
            {
                Console.WriteLine("Game has beeen terminated.");
                return;
            }

            if (playerA == playerB)
            {
                Console.Write("Tie ! Play Again");
                Play();

            } 
            else if (playerA == "rock")
            {
                if (playerB == "paper")
                {
                    Console.Write("Result : player B Wins");
                }else if (playerB == "scissors")
                {
                    Console.Write("Result : player A Wins");
                } else
                {
                    Console.Write("Invalid Input!");
                    Play();
                }
            } 
            else if (playerA == "paper")
            {
                if (playerB == "rock")
                {
                    Console.Write("Result : player A Wins");
                }else if (playerB == "scissors")
                {
                    Console.Write("Result : player B Wins");
                } else
                {
                    Console.Write("Invalid Input!");
                    Play();
                }
            }
            else if (playerA == "scissors")
            {
                if (playerB == "paper")
                {
                    Console.Write("Result : player A Wins");
                }else if (playerB == "rock")
                {
                    Console.Write("Result : player B Wins");
                } else
                {
                    Console.Write("Invalid Input!");
                    Play();
                }
            }
        }
    }
}