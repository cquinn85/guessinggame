using System;
using System.Reflection.Metadata;

namespace numberguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random(); //allows us to call the next method which will create a random number.
            var favNumber = r.Next(1, 1000); // had to do above to call Next (the method) which stores a random number in favNumber

            Console.WriteLine("Guess what my favorite number is:");

            int userInput;

            
            do
            {
                userInput = int.Parse(Console.ReadLine()); //asks for user input (ReadLine) int.Parse converts to integer.

                if (userInput < favNumber) //evaluates to true or false
                {
                    Console.WriteLine($"Too Low"); //true scope (scope is between the curly braces)
                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Too High");
                }

                else //this is a catch all no need for a condition to evaluate
                {
                    Console.WriteLine($"Nevermind");
                }

            } while (userInput != favNumber);
           
        }
    }
}

                      

   
