using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task01
{
    public class Fizzbuzz
    {
        public string getFizzyBuzz(int value)
        {
            if (value % 3 == 0 && value % 7 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 7 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "Gotcha";
            }
        }

        public static void Main(string[] args) 
        {
        }
    }
}

