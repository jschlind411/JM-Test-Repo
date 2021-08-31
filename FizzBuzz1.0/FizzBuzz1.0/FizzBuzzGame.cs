using System;
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

        public int currentPlayer { get; set; } = 1;

        public int turn { get; set; }

        public void Play()
        {
            var _fizzBuzzer = new FizzBuzzer();

            turn++;
            if(turn % 2 != 0)
            {
                Console.WriteLine("Player One, pick a number");
                var input = Convert.ToInt32(Console.ReadLine());

                var answer = _fizzBuzzer.Check(input);
            }
            else
            {
                Console.WriteLine("Player Two, pick a number");
                var input = Convert.ToInt32(Console.ReadLine());

                var answer = _fizzBuzzer.Check(input);
            }  
        }
    }
}
