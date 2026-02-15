using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                string playerChoice = GetPlayerChoice();
                string computerChoice = GetComputerChoice(random);

                Console.WriteLine($"You chose: {playerChoice}");
                Console.WriteLine($"Computer chose: {computerChoice}");

                DetermineWinner(playerChoice, computerChoice);

                Console.WriteLine("Play again? (Y/N)");
                string answer = Console.ReadLine().ToLower();
                playAgain = answer == "y";
            }

            Console.WriteLine("Thank you for playing!");
        }

        static string GetPlayerChoice()
        {
            string choice = "";

            while (choice != "rock" && choice != "paper" && choice != "scissors")
            {
                Console.Write("Enter rock, paper, or scissors: ");
                choice = Console.ReadLine().ToLower();
            }

            return choice;
        }

        static string GetComputerChoice(Random random)
        {
            switch (random.Next(1, 4))
            {
                case 1: return "rock";
                case 2: return "paper";
                default: return "scissors";
            }
        }

        static void DetermineWinner(string player, string computer)
        {
            if (player == computer)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (player == "rock" && computer == "scissors") ||
                (player == "paper" && computer == "rock") ||
                (player == "scissors" && computer == "paper"))
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }
        }
    }
}
