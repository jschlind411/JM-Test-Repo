using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace FizzBuzz_Tester
{
    public class FizzBuzzGame_Tests
    {
        public FizzBuzzGame_TwoPlayer _fizzBuzzGame { get; set; }

        public FizzBuzzGame_Tests()
        {
            _fizzBuzzGame = new FizzBuzzGame_TwoPlayer();
        }

        [Trait("FizzBuzzGame Constructor", "Object Creation")]
        public class FizzBuzzGameLogic : FizzBuzzGame_Tests
        {
            [Fact(DisplayName = "Object Can Be Created with Correct Defaults")]
            public void NewFizzBuzzGame_CanBeCreated_WithCorrectDefaults()
            {
                Assert.NotNull(_fizzBuzzGame);
             
                Assert.Equal(0, _fizzBuzzGame.round);
            }
        }
    }
}
