﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public FizzBuzzGame()
        {
        }

        public int round { get; set; }

        FizzBuzzer fizzBuzzer = new();
        FizzBuzzPlayer playerOne = new();
        FizzBuzzPlayer playerTwo = new();

        public void Play()
        {
            playerOne.Name = "One";
            playerTwo.Name = "Two";
            
            Console.WriteLine("Welcome to the FizzBuzz game!\nHow many rounds would you like to play?");
            round = Convert.ToInt32(Console.ReadLine());

            for (int count = 1; count < round; count++)
            {
                TakeATurn(playerOne);
                TakeATurn(playerTwo);
            }

            Console.WriteLine("Player One scored " + playerOne.Score + " points.\nPlayer Two scored " + playerTwo.Score + " points.");

            if(playerOne.Score > playerTwo.Score)
            {
                Console.WriteLine("Congratulations, Player One. You're the Winner!");
            }
            else if(playerTwo.Score > playerOne.Score)
            {
                Console.WriteLine("Congratulations, Player Two. You're the Winner!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine("Thank you for playing FizzBuzz!");
            Console.ReadLine();
        }

        public void TakeATurn(FizzBuzzPlayer player)
        {
            Random random = new();
            int number = random.Next(1, 200);
            var answer = fizzBuzzer.Check(number);

            Console.WriteLine("Player " + player.Name + ", here is your number: " + number.ToString() + "\nWhat is your reply?");
            var reply = (Console.ReadLine());

            if (answer == reply)
            {
                player.Score++;
                Console.WriteLine("That's right, Player " + player.Name + "!");
            }
            else
            {
                Console.WriteLine("Sorry, that's the wrong answer.");
            }
        }
    }
}
