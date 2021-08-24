using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz_Tester
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateFizzBuzzer_WithCorrectDefaults()
        {
            var fizzBuzzer = new FizzBuzzer();

            Assert.NotNull(fizzBuzzer);
            Assert.Equal(0, fizzBuzzer.FizzCount);
        }
    }
}
