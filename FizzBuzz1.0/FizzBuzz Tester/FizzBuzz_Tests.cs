using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz_Tester
{
    public class FizzBuzz_Tests
    {
        public FizzBuzzer _fizzBuzzer { get; set; }

        public FizzBuzz_Tests()
        {
            _fizzBuzzer = new FizzBuzzer();
        }

        [Fact]
        public void NewFizzBuzzer_IsCreateed_WithCorrectDefaults()
        {
            Assert.NotNull(_fizzBuzzer);

            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            Assert.Equal(0, _fizzBuzzer.TotalCount);
        }

        [Fact]
        public void FizzBuzzer_ReturnsValueFrom_Check()
        {
            string response = _fizzBuzzer.Check(1);

            Assert.NotNull(response);
        }

        [Fact]
        public void FizzBuzzer_IteratesTotalCount_WhenCheckingValues()
        {
            _fizzBuzzer.Check(1);

            Assert.Equal(1, _fizzBuzzer.TotalCount);

            _fizzBuzzer.Check(1);

            Assert.Equal(2, _fizzBuzzer.TotalCount);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(36)]
        public void FizzBuzzer_ReturnsFizz_GivenAFizzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("Fizz", response);
        }

        [Fact]
        public void FizzBuzzer_ReturnsBuzz_GivenABuzzValue()
        {
            var response = _fizzBuzzer.Check(5);

            Assert.Equal("Buzz", response); 
        }
    }
}
