using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating random obj from random class
            Random random = new Random();

            // starting
            Console.WriteLine("WELCOME TO NUMBER GUESSING GAME\n" +
                "YOU HAVE TO GUESS A NUMBER 1 - 100\n" +
                "YOU WILL GET 10 CHANCES TO GUESS THE NUMBER");

            // variables
            int chance = 10;
            int number = random.Next(1, 101);
            int guess;

            // game loop
            while (chance > 0)
            {
                Console.Write("Guess the number : ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess <= 0)
                {
                    Console.WriteLine("Guess is too Low!\n" +
                        "chances left: " + (chance-1));
                }
                else if (guess > 100)
                {
                    Console.WriteLine("Guess is too High!\n" +
                        "chances left: "  + (chance-1));
                    
                }
                else if(guess == number)
                {
                    // game won
                    Console.WriteLine("YOU GUESSED THE NUMBER RIGHT\n" +
                        "CONGRATULATIONS, YOU WON THE GAME");
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Try guessing the number a little higher\n" +
                        "chances left: " + (chance-1));
                }
                else if (guess > number)
                {
                    Console.WriteLine("Try guessing the number a little lower\n" +
                        "chances left: " + (chance - 1));
                }
                else
                {
                    Console.WriteLine("Invalid Input!\n" +
                        "your chance is retained!");
                    chance++;
                }
                chance--;
            }

            // game over
            if (chance == 0)
            {
                Console.WriteLine("SORRY, YOU LOST THE GAME\n" +
                    "THE CORRECT NUMBER IS: " + number);
            }
            Console.ReadKey();
        }
    }
}