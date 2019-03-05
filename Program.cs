using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRTechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much you would like to save");

            decimal userInput;

            // does a check to make sure user is typing the correct format of input such as decimal or interger, if it's wrong, it throws an error
            while (!decimal.TryParse(Console.ReadLine(), out userInput)) 
            {
                Console.WriteLine("Invalid input, please try again");
            }

            // based on the user input, one of the below condition will be passed and calls th interest rate method
            if (userInput < 1000)
            {
                InterestRate(userInput, 1);
            }

            else if (userInput >= 1000 && userInput < 5000)
            {
                InterestRate(userInput, 1.5);
            }

            else if (userInput >= 5000 && userInput < 10000)
            {
                InterestRate(userInput, 2);
            }

            else if (userInput >= 10000 && userInput < 50000)
            {
                InterestRate(userInput, 2.5);
            }

            else
            {
                InterestRate(userInput, 3);
            }
        }

        public static void InterestRate(decimal userValue, double interest)
        {
            // this first does the interest rste / 100 then multiply by the user input
            decimal result = ((decimal)interest / 100) * userValue;
            
            // then rounds up to 2 decimal places and shows the currency symbol as well
            Console.WriteLine("Interest Rate:{0:c}", Math.Round(result,2));
        }
    }
}
