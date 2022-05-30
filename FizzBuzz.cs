namespace FizzBuzz
{

    public class FizzBuzz
    {

        public static void Main(string[] args)
        {

            int maxNumber;
            if (args.Length == 0)
            {
                maxNumber = 100;
            }

            else
            {
                maxNumber = int.Parse(args[0]);
            }

        }
    }
}