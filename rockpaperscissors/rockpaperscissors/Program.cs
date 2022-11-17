using System;

namespace rockpaperscissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            while (running == true)
            {
                Random rnd = new Random();

                int choice = rnd.Next(0, 3);

                string[] options = { "rock", "paper", "scissors" };
                string computer = options[choice];
                Console.WriteLine("enter a choice (rock, paper, scissors): ");
                string player = Console.ReadLine();

                while (!options.Contains(player))
                {
                    Console.WriteLine("enter a choice (rock, paper, scissors): ");
                    player = Console.ReadLine();
                }

                Console.WriteLine($"player: {player}");
                Console.WriteLine($"computer: {computer}");

                if (player == computer)
                {
                    Console.WriteLine("tie");
                }

                else if (player == "rock" && computer == "scissors")
                {
                    Console.WriteLine("win");
                }

                else if (player == "scissors" && computer == "paper")
                {
                    Console.WriteLine("win");
                }

                else if (player == "paper" && computer == "rock")
                {
                    Console.WriteLine("win");
                }

                else
                {
                    Console.WriteLine("lose");
                }

                Console.WriteLine("continue?");



                if (Console.ReadLine().ToLower() != "y" || Console.ReadLine().ToLower() != "yes")
                    {
                        running = false;
                    }
            }

            Console.WriteLine("thank you for playing");
        }
    }
}