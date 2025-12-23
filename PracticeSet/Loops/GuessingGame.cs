using System.Runtime.CompilerServices;

namespace PracticeQuestions
{
    public class GuessingGame
    {
        /// <summary>
        /// Method to play the Guessing Game using do-while loop
        /// 
        /// </summary>
        public void Play()
        {
            int secretNumber=98;
            int playerGuessedNumber=0;
            
            do
            {
                Console.WriteLine("Enter an integer to guess if it is right:");
                String? input = Console.ReadLine();
                int.TryParse(input, out playerGuessedNumber);

                if (playerGuessedNumber == secretNumber)
                {
                    Console.WriteLine("Congratulations! You Guessed it right");
                }
            } while (playerGuessedNumber != secretNumber);
            
            
        }
    }
}