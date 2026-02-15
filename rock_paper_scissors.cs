using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scessiors
{
    internal class rock_paper_scissors
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            String player;
            String computer;
            bool playagain = true;
            while (playagain)
            {
                player = "";
                computer = "";

                while (player != "rock" && player != "paper" && player != "scissors")
                {

                    Console.WriteLine("Enter rock paper or scissors");
                    player = Console.ReadLine();
                }
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissors";
                        break;
                }
                Console.WriteLine("you chose: " + player);
                Console.WriteLine("computer chose: " + computer);
                switch(player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            Console.WriteLine("its a tie");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("u lose");
                        }
                        else if (computer == "scissors")
                        {
                            Console.WriteLine("u won!");
                        }
                        break;
                    case "paper":
                        if (computer == "rock")
                        {
                            Console.WriteLine("u won!");

                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("its a tie!");

                        }
                        else if (computer == "scissors")
                        {
                            Console.WriteLine("u lost!");
                        }
                        break;
                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("u lost!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("u won!");

                        }
                        else if (computer == "scissors")
                        {
                            Console.WriteLine("its a tie!");
                        }
                        break;
                }
                Console.WriteLine("play again? (Y/N)");
                string answer = Console.ReadLine();
                if (answer != "Y")
                {
                    playagain = false;
                    Console.WriteLine("thank you for playing my game");
                }



            }
        }
    }
}
    

