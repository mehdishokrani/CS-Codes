using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(21);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
            string inp;
            int count = 0;
            // Keep track of the number of guesses and the current user guess
            while(true){
            inp = Console.ReadLine();
            try{
                int number = int.Parse(inp);
                if(number<0)
                break;
                count ++;
                if(number == theNumber){
                    Console.WriteLine($"\nYou made it in total {count} gusses\n");
                    break;
                }
                else if(number<theNumber)
                Console.WriteLine("My number is higher than yours \nEnter bigger number: ");
                else
                Console.WriteLine("My number is lower than yours \nEnter smaller number: ");
                

            }
            catch{
                Console.WriteLine("Please enter a number between 0 and 20");
            }
            }

        }
    }
}
