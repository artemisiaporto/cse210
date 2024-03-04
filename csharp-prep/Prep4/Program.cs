using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   ///Creates a list called numbers
        List<int> numbers = new List<int>();
        int userNum = -1;
        ///Allow the user to type numbers until types a 0, and add them to the list "numbers"
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            string numberReceived = Console.ReadLine();
            userNum = int.Parse(numberReceived);
        
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        ///Calculate the sum of the numbers in the list "numbers"
        float sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        ///Calculate the average of the numbers in the list "numbers"
        float average;
        average = sum/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        ///Find the largest number in the numbers list
        int largestNum = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNum}");
        ///Find the smallest positive number in the list "numbers"
        int smallPos = largestNum;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallPos)
            {
                smallPos = num;
            }
        }
        Console.WriteLine($"The smallest positive is: {smallPos}");
        ///Print the sorted list "numbers"
        List<int> numbersSort = new List<int>();
        numbersSort.AddRange(numbers);
        numbersSort.Sort();
        foreach (int num in numbersSort)
        {
            Console.WriteLine(num);
        }
    }
}