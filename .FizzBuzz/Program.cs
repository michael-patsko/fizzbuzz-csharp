namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int maxNumber = 100;

            for (int i = 1; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
