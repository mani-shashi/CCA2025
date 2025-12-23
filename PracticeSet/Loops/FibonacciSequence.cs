namespace PracticeQuestions
{
    public class FibonacciSequencePrinter
    {
        /// <summary>
        /// Print fibonacci Sequence upto N instance
        /// </summary>
        /// <param name="N"> N Limit as Int</param>
        public void printFibonacciSequence(int N)
        {
            int first = 0;
            int second = 1;
            int count = 1;

            Console.WriteLine($"Fibonacci Sequence upto {N} instance: ");

            do{
                Console.Write($" {first}");
                int next = first + second;
                first = second;
                second = next;
                

                count++;
            } while (count <= N);

            Console.WriteLine();
        }
    }
}