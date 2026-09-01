using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int value = -1;
        List <int> numbers = new List<int>();
        while (value != 0)
        {
            Console.Write("Enter value: ");
            string num = Console.ReadLine();
            value = int.Parse(num);
            if (value != 0)
            {
                numbers.Add(value);
            }
        }
        
        int sum = 0;

        foreach (int number in numbers)
        {
            sum+= number;
        }
        
        int count = numbers.Count;
        decimal average = (decimal)sum / count;
        int large = numbers[0];
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");

        foreach (int number in numbers)
        {
            if (number > large)
            {
                large = number;
            }

        }
        Console.WriteLine($"The largest number is {large}");


    }
}