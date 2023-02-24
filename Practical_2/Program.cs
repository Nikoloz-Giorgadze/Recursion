namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of first {number} is: {ResultSum(1,number)}");
        }
        static int ResultSum(int firstN, int lastN)
        {
            return RecursionSum(firstN, lastN);
        }
        static int RecursionSum(int firstN,int value)
        {
            if (value == firstN)
                return value;
            return value+RecursionSum(firstN, value-1);

        }
    }
}