using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        double total = 0;
        foreach (int nums in numbers)
        {
            total += nums;
        }
        Console.WriteLine($"The sum is: {total}");

        double average = total / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");

        int bigNum = numbers[0];
        for (int i = 1; i < numbers.Count; i++) 
        {
            if (bigNum < numbers[i])
            {
                bigNum = numbers[i];
                i++;
            }
        }
        Console.WriteLine($"The largest number is: {bigNum}");
    }
}