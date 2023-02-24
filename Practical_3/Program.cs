namespace Practical_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine($"In {number} is {DigitCount(number, 0)} digits.");
           
        }

        static int DigitCount(int number, int digits)
        {
            return RecursionCount(number, digits);
        }
        static int RecursionCount(int number, int digits)
        {
            if (number == 0)
                return digits;
            else
            {
                number /= 10;
                digits++;
               return RecursionCount(number, digits);
            }
        }

    }
}