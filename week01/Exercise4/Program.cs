using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int userNum = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNum != 0)
        {
            Console.WriteLine("Enter number:");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                number.Add(userNum);
            }
        }

        int sum = number.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = number.Average();
        Console.WriteLine($"The average is: {average}");

        int largest_num = number.Max();
        Console.WriteLine($"The largest number is: {largest_num}");
    }
}