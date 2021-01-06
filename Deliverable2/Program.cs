using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have mor:'heads' or 'tails'?");
            string headsOrTailsGuess;
            headsOrTailsGuess = Console.ReadLine();

            Console.WriteLine("Let's flip a coin, how many times should I flip the coin?");
            int numberOfFlips = int.Parse(Console.ReadLine());

            int correctCount;
            correctCount = 0;

            

            
            Console.WriteLine("the Results are:");

            for (int timesFlipped = 0;  numberOfFlips >= timesFlipped + 1; timesFlipped++)
            {
                
                Random rnd = new Random();
                int number = rnd.Next(100);
       
             
                string coinFlip;
                if (number % 2 > 0)
                {
                    coinFlip = "tails";
                    Console.WriteLine("tails");


                }
                else
                {
                    coinFlip = "heads";
                   Console.WriteLine("heads");

                }
                

                if (headsOrTailsGuess == coinFlip)
                {
                    correctCount++;
                }
                

            }
            double a = correctCount;
            double b = numberOfFlips;
            double guessPercentage = a / b * 100;
           

            Console.WriteLine("Your guess, " +  headsOrTailsGuess + ", came up " + correctCount + " times!That's " + guessPercentage + "%");


        }
    }
}

