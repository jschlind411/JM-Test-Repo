using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzGame_OnePlayer
    {
        public FizzBuzzGame_OnePlayer()
        {
        }

        public int round { get; set; }

        FizzBuzzer fizzBuzzer = new();
        FizzBuzzPlayer player = new();
        
        public void Play()
        {
            if(player.Name == "")
            {
                Console.WriteLine("Great!\nPlease enter your name.");
                player.Name = Console.ReadLine();
            }
            
            Console.WriteLine("How many rounds would you like to play, " + player.Name + "?");
            round = Convert.ToInt32(Console.ReadLine());
            
            for (int count = 0; count < round; count++)
            {
                TakeATurn(player);
            }

            Console.WriteLine(player.Name + ", you scored " + player.Score + " points, out of a total of " + round + ".\nWould you like to play again?");
            var reply = Console.ReadLine();

            if ((reply.ToLower() == "yes") || (reply.ToLower() == "y"))
            {
                Play();
            }
            else
            {
                Console.WriteLine("Thank you for playing FizzBuzz!");
            }
        }

        public void TakeATurn(FizzBuzzPlayer player)
        {
            Random random = new();
            int number = random.Next(50, 200);
            var answer = fizzBuzzer.Check(number);

            Console.WriteLine("The number is: " + number.ToString() + "\nWhat is your reply?");
            var reply = Console.ReadLine();

            if (answer.ToLower() == reply.ToLower())
            {
                player.Score++;
                Console.WriteLine("That's right, " + player.Name + "!");
            }
            else
            {
                Console.WriteLine("Sorry, that's the wrong answer.");
            }
        }
    }
}
