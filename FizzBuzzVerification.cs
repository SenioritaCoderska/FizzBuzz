using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzVerification
    {
        
        public string GetResult { get { return _results; }}
        private string _results;
        public FizzBuzzVerification()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception($"{Environment.NewLine} Please provide the number as an input...");
            }
            _results= input % 2 == 0 ? input % 5 == 0 ? "FizzBuzz" : "Fizz" : input % 5 == 0 ? "Buzz" : input.ToString();
        }

    } 
}
