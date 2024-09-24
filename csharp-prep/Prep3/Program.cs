using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "yes";
        do
        {
            Random randNum = new Random();
            int num = randNum.Next(1,20);
            int guess;
            int guessNum = 0;
            do
            {
                guessNum++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > num) 
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < num)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != num);

            Console.WriteLine($"The magic number is {num}- Wow you guessed it!!");
            Console.WriteLine($"It only took you {guessNum} guesses!");
            
            Console.Write("Want to play again? Enter 'yes' if so: ");
            input = Console.ReadLine();
        } while (input == "yes");

    }
}