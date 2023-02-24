namespace Practical_4

{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} in power {degree} is:{NumberDegree(number, degree)}");
        }
        static int NumberDegree(int number, int degree)
        {
            return RecursionDegree(number, degree);
        }
        static int RecursionDegree(int number, int degree)
        {
            if (degree == 0)
                return 1;
            else
                return number * RecursionDegree(number, degree - 1);
        }
    }
}