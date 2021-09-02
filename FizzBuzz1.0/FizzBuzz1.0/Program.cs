using System;
using FizzBuzz;

namespace FizzBuzz1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FizzBuzz game!\nWould you prefer one player or two?");

            bool validInput = false;
            while(validInput == false)
            {
                var choice = Console.ReadLine();

                if ((choice == "1") || (choice.ToLower() == "one"))
                {
                    var _fizzBuzzGame = new FizzBuzzGame_OnePlayer();
                    _fizzBuzzGame.Play();
                    break;
                }
                else if ((choice == "2") || (choice.ToLower() == "two"))
                {
                    var _fizzBuzzGame = new FizzBuzzGame_TwoPlayer();
                    _fizzBuzzGame.Play();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer.");
                }
            }
            
        }
    }
}
