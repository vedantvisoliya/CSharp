using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a random object from random class
            Random random = new Random();

            // starting
            Console.WriteLine("ROCK-PAPER-SCISSORS GAME\n" +
                "Enter - 1 for Rock\n" +
                "Enter - 2 for Paper\n" +
                "Enter - 3 for Scissors\n" +
                "It is 5 round game.");
            Console.WriteLine();

            // variables
            int admin_choice;
            int bot_choice;
            int admin_score = 0;
            int bot_score = 0;
            int rounds = 1;

            // game loop

            while(rounds <= 5)
            {
                Console.WriteLine("********* ROUND " + rounds + " *********\n" +
                                  "     " + admin_score + "           " + bot_score);
                Console.WriteLine();
                Console.Write("ADMIN's Choice: ");
                admin_choice = Convert.ToInt32(Console.ReadLine());
                bot_choice = random.Next(1, 4);
                Console.Write("BOT's Choice: " + bot_choice);
                Console.WriteLine();

                if (admin_choice == 1 && bot_choice == 1)
                {
                    // rock-rock
                    Console.WriteLine("   !ROCK!   VS   !ROCK!");
                    Console.WriteLine("     !ROUND DRAW!");
                    Console.WriteLine();
                }
                else if (admin_choice == 2 && bot_choice == 2)
                {
                    // paper-paper
                    Console.WriteLine("   !PAPER!   VS   !PAPER!");
                    Console.WriteLine("     !ROUND DRAW!");
                    Console.WriteLine();
                }
                else if (admin_choice == 3 && bot_choice == 3)
                {
                    // scissors-scissors
                    Console.WriteLine("   !SCISSORS!   VS   !SCISSORS!");
                    Console.WriteLine("     !ROUND DRAW!");
                    Console.WriteLine();
                }
                else if (admin_choice == 1 && bot_choice == 2)
                {
                    // rock-paper
                    Console.WriteLine("   !ROCK!   VS   !PAPER!");
                    Console.WriteLine("     !BOT WON THE ROUND!");
                    Console.WriteLine();
                    bot_score++;
                }
                else if (admin_choice == 1 && bot_choice == 3)
                {
                    // rock-scissors
                    Console.WriteLine("   !ROCK!   VS   !SCISSORS!");
                    Console.WriteLine("     !ADMIN WON THE ROUND!");
                    Console.WriteLine();
                    admin_score++;
                }
                else if (admin_choice == 2 && bot_choice == 1)
                {
                    // paper-rock
                    Console.WriteLine("   !PAPER!   VS   !ROCK!");
                    Console.WriteLine("     !ADMIN WON THE ROUND!");
                    Console.WriteLine();
                    admin_score++;
                }
                else if (admin_choice == 2 && bot_choice == 3)
                {
                    // paper-scissors
                    Console.WriteLine("   !PAPER!   VS   !SCISSORS!");
                    Console.WriteLine("     !BOT WON THE ROUND!");
                    Console.WriteLine();
                    bot_score++;
                }
                else if (admin_choice == 3 && bot_choice == 1)
                {
                    // scissors-rock
                    Console.WriteLine("   !SCISSORS!   VS   !ROCK!");
                    Console.WriteLine("     !BOT WON THE ROUND!");
                    Console.WriteLine();
                    bot_score++;
                }
                else if (admin_choice == 3 && bot_choice == 2)
                {
                    // scissors-paper
                    Console.WriteLine("   !SCISSORS!   VS   !PAPER!");
                    Console.WriteLine("     ADMIN WON THE ROUND!");
                    Console.WriteLine();
                    admin_score++;
                }
                rounds++;
            }
            Console.WriteLine();
            if (admin_score > bot_score)
            {
                Console.WriteLine("     !ADMIN WON THE MATCH");
            }
            else if (admin_score < bot_score)
            {
                Console.WriteLine("     !BOT WON THE MATCH");
            }
            else
            {
                Console.WriteLine("     !MATCH DRAW!");
            }
            Console.ReadKey();
        }
    }
}
