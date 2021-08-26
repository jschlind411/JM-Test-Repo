using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace FizzBuzz_Tester
{
    class FizzBuzzGame_Tests
    {
        public FizzBuzzGame _fizzBuzzGame { get; set; }

        public FizzBuzzGame_Tests()
        {
            _fizzBuzzGame = new FizzBuzzGame();
        }

        [Trait("FizzBuzzGame Constructor", "Object Creation")]
        public class FizzBuzzGameLogic : FizzBuzzGame_Tests
        {
            [Fact(DisplayName = "Object Can Be Created")]
            public void NewFizzBuzzGame_CanBeCreated()
            {
                Assert.NotNull(_fizzBuzzGame);
            }
        }
    }
}
