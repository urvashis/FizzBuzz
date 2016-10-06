using System;
using System.Collections.Generic;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        var userInput = Console.ReadLine();
        int number;
        if (Int32.TryParse(userInput, out number))
            Console.WriteLine(GetFizzBuzz(number));
        else
            Console.WriteLine("Please enter a valid integer number (Int32)");
    }

    public static string GetFizzBuzz(int number)
    {
        var multipleOf3 = number % 3 == 0;
        var multipleOf5 = number % 5 == 0;

        if (multipleOf3 && multipleOf5)
            return "Fizzbuzz";
        if (multipleOf3)
            return "Fizz";
        if (multipleOf5)
            return "Buzz";
        return number.ToString();
    }
  }
}


