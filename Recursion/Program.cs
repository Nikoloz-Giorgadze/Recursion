namespace Practical_1
{
    class Proram
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Recursion(number);

        }

        static void Recursion(int number)
        {
            if (number > 0)
            {
                Recursion(number - 1);
                Console.WriteLine(number);

            }
        }
    }
}