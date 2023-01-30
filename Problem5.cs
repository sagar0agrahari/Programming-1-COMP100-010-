using System;
namespace Week3Demo
{
    public class Problem5
    {
        static void Main(String[] args) {
            char c;
            Console.WriteLine("Enter one character");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your response was " + c);

            Console.WriteLine($"Your response was {c} ");
            Console.ReadLine();
        }
    }
}
