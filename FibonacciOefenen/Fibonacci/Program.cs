namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();


        }

        /// <summary>
        /// excutes the Fibonacci
        /// </summary>
        static void Fibonacci()
        {
            int number1 = 0;
            int number2 = 1;
            int number3 = 0;


            int count = 20;
            for (int i = 0; i < count; i++)
            {
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;

                Console.WriteLine(number3);

            }
        }
    }
}