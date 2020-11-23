using System;
using System.IO;

namespace NubmerGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number guessing game!");
            Console.WriteLine("Whats your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello {0} lets play a game!", Name);
            while(true)
            {
            Random Rand = new Random();
            int Num = Rand.Next(1,10);
            int guesslimit = 3;
            int guesscount = 0;
            int Guess= 0;
            
            Console.WriteLine("Guess a number between 1 and 10");
            
            while (guesscount < guesslimit)
            {
            string input = Console.ReadLine();
            if(!int.TryParse(input, out Guess))
                {   
                Console.WriteLine("enter a valid number");
                }
            else if (Guess<=0 || Guess >=11) 
            {
                Console.WriteLine("Enter a number between 1 and 10");
            }
            else 
            {
              if (Guess == Num)
                {
                    Console.WriteLine("Congratulation! You Won!!!");
                    break;
                    
                }
                else
                {
                    guesscount++;
                    Console.WriteLine("Wrong number. Please try Again.");
                }
            
            }
            
            }
            if (guesscount == guesslimit && Guess != Num)
            {
                Console.WriteLine("Sorry you are out of guesses");
            }
            Console.WriteLine("Press Y to play again. Press anything else to quit the game.");
            if (Console.ReadLine() == "Y")
            {
                continue;
            }
            else
            {
                return;
            }
        }

        }
    }
}
    