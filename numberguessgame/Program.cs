using System;

namespace numberguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"Too Low");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine($"Too High");
            }

            else //this is a catch all no need for userInput == favNumber
            {
             Console.WriteLine($"Nevermind");
            }

           
        
        }
    }
}

                      

   
