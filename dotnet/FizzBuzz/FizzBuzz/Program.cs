using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number (type exit if you want to leave at any time)");
            var fizzBuzz = new FizzBuzz();
            var userInput = Console.ReadLine();
            while(userInput != "exit"){
                Console.WriteLine(fizzBuzz.GetFizzBuzz(userInput));
                userInput = Console.ReadLine();
            }
            
        }
    }
    public class FizzBuzz
    {
        public string GetFizzBuzz(string userInput)
        {
            int number;
            if (Int32.TryParse(userInput, out number))
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
            return "Please enter a valid integer number (Int32)";
        }
    }
}


