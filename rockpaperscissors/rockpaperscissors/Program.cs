using System;

namespace rockpaperscissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int wins = 0;
            int losses = 0;
            int ties = 0;
            bool running = true;
            while (running == true)
            {
                Console.Clear();
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
                    ties += 1;
                    Console.WriteLine("tie");
                }

                else if (player == "rock" && computer == "scissors")
                {
                    wins += 1;
                    Console.WriteLine("win");
                }

                else if (player == "scissors" && computer == "paper")
                {
                    wins += 1;
                    Console.WriteLine("win");
                }

                else if (player == "paper" && computer == "rock")
                {
                    wins += 1;
                    Console.WriteLine("win");
                }

                else
                {
                    losses += 1;
                    Console.WriteLine("lose");
                }

                Console.WriteLine($"wins:{wins}; losses:{losses}; ties:{ties}");
                Console.WriteLine("continue?(y/n)");



                if (Console.ReadLine().ToLower() != "y")
                {
                    running = false;
                }
            }
            Console.Clear();
            Console.WriteLine("thank you for playing");
            Console.WriteLine($"final score: wins:{wins}; losses:{losses}; ties:{ties}");
        }
    }
}