namespace PracticeQuestions
{
    public class ContinueExample
    {
        public void printMultiples()
        {
            Console.WriteLine("Numbers from 1 to 50 without multiples of 3 are: ");
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }
    }
}