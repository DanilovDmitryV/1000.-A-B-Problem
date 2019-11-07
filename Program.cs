using System;

namespace _1000.A_B_Problem
{
    public class Sum
    {
        private static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(numbers[0]) + int.Parse(numbers[1]));
        }
    }
}
