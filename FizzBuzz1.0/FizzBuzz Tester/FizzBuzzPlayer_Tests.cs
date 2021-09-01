using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz_Tester
{
    public class FizzBuzzPlayer_Tests
    {
        public FizzBuzzPlayer _fizzBuzzPlayer { get; set; }

        public FizzBuzzPlayer_Tests()
        {
            _fizzBuzzPlayer = new FizzBuzzPlayer();
        }

        [Fact]
        public void NewFizzBuzzPlayer_CanBeCreated_withCorrectDefaults()
        {
            Assert.NotNull(_fizzBuzzPlayer);

            Assert.Equal("", _fizzBuzzPlayer.Name);
            Assert.Equal(0, _fizzBuzzPlayer.Score);
        }
    }
}
