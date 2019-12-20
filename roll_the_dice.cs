using System;

namespace roll_the_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Welcome to Roll The Dice!");
            Console.WriteLine("Roll any number of dice and give us the sum of their outcomes and we will tell you every possible combination that you could have gotten\n");


            //Get and validate the number of dice rolled
            Console.WriteLine("How many dice have you rolled?");

            int no_of_dice;
            bool converted = int.TryParse(Console.ReadLine(), out no_of_dice);

            if (!converted)
            {
                while (!converted)
                {
                    Console.WriteLine("Please input a number\nHow many dice have you rolled?");
                    converted = int.TryParse(Console.ReadLine(), out no_of_dice);
                }
            }
  

            //Get and validate the total outcome of the dice rolled
            Console.WriteLine("What was the total outcome?");

            int total_outcome;
            converted = int.TryParse(Console.ReadLine(), out total_outcome);

            if (!converted)
            {
                while (!converted)
                {
                    Console.WriteLine("Please input a number\nWhat was the total outcome?");
                    converted = int.TryParse(Console.ReadLine(), out total_outcome);
                }
            }
                
                    
            //Get the combinations
            Calculator(no_of_dice, total_outcome);
        }

        public static void Calculator(int no_of_dice, int total_outcome)
        {
            Console.WriteLine($"Successful: {no_of_dice}, {total_outcome}");
        }
    }
}
