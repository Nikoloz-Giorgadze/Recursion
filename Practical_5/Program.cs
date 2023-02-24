using System;
using System.Security.Cryptography.X509Certificates;

namespace Practical_5
{
    class Program
    {
        static void Main()
        {
            string text;
            bool tf;

            Console.Write(" Input a string : ");
            text = Console.ReadLine();
            tf = IsPalindrome(text);
            if (tf == true)
            {
                Console.WriteLine($" The {text} is Palindrome.");
            }
            else
            {
                Console.WriteLine($" The {text} is not a Palindrome.");
            }
        }
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}