using System;
using FizzBuzz;

namespace FizzBuzz1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FizzBuzz game!\nWould you prefer one player or two?");
            var choice = Console.ReadLine();

            if (choice == "one")
            {
                var _fizzBuzzGame = new FizzBuzzGame_OnePlayer();
                _fizzBuzzGame.Play();
            }
            else
            {
                var _fizzBuzzGame = new FizzBuzzGame_TwoPlayer();
                _fizzBuzzGame.Play();
            }
        }
    }
}
