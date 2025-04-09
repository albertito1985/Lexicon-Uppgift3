namespace Lexicon_Uppgift3.Helpers
{
    public static class Utilities
    {
        public static int NumberInput()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("The input is not a number.");
            }
            return -1;
        }

        public static string StringInput()
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                throw new ArgumentException("The input is empty.");
            }
            return "invalid";

        }

        public static double DoubleInput()
        {
            string input = Console.ReadLine();

            if (Double.TryParse(input, out Double result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Write the input with decimals ex 100.865.");
            }
            return -1;
        }
    }
}
