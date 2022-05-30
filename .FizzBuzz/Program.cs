namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<string> outputString = new List<string>();
            int maxNumber = 100;
            bool isEmpty;
            int stringLength;

            for (int i = 1; i <= maxNumber; i++)
            {
                if (fizzBuzz.IsDivisibleBy(i, 3))
                {
                    outputString.Add("Fizz");
                }
                if (fizzBuzz.IsDivisibleBy(i, 5))
                {
                    outputString.Add("Buzz");
                }

                stringLength = outputString.Count;
                isEmpty = (stringLength == 0);

                if (isEmpty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(string.Join("", outputString));
                }
                outputString.Clear();
            }
        }
    }
}
