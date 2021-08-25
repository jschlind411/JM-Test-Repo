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
    }

    [Trait("FizzBuzzer Constructor", "Object Creation")]
    public class ObjectCreationAndDefaults : FizzBuzz_Tests
    {
        [Fact(DisplayName = "Object Created with Correct Defaults")]
        public void NewFizzBuzzer_IsCreateed_WithCorrectDefaults()
        {
            Assert.NotNull(_fizzBuzzer);

            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            Assert.Equal(0, _fizzBuzzer.TotalCount);
        }
    }

    [Trait("FizzBuzzer Logic", "Ordinary Numbers")]
    public class OrdinaryNumbers : FizzBuzz_Tests
    {
        [Fact(DisplayName = "A NonNull value should always be returned")]
        public void FizzBuzzer_ReturnsValueFrom_Check()
        {
            string response = _fizzBuzzer.Check(1);

            Assert.NotNull(response);
        }

        [Fact(DisplayName = "TotalCount should always be Iterated")]
        public void FizzBuzzer_IteratesTotalCount_WhenCheckingValues()
        {
            _fizzBuzzer.Check(1);

            Assert.Equal(1, _fizzBuzzer.TotalCount);

            _fizzBuzzer.Check(1);

            Assert.Equal(2, _fizzBuzzer.TotalCount);
        }

        //TODO: This Unit Test is for you Mike :D
        [Fact(DisplayName = "Checked Number should be returned if not a fizz/buzz/fizzbuzz value")]
        public void FizzBuzzer_ReturnsNumber_IfNot_Fizz_Buzz_FizzBuzz()
        {
            var response = _fizzBuzzer.Check(1);

            int.TryParse(response, out var numberToCheck);

            Assert.Equal(1, numberToCheck);
        }
    }

    [Trait("FizzBuzzer Logic", "Fizz Numbers")]
    public class FizzLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Check Returns Fizz given a Fizz value")]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(36)]
        public void FizzBuzzer_ReturnsFizz_GivenAFizzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("Fizz", response);
        }

        [Fact(DisplayName = "Correctly Iterates Counts with Fizz values")]
        public void FizzBuzzer_CorrectlyIteratesCounts_WhenCheckingFizzValues()
        {
            _fizzBuzzer.Check(3);

            Assert.Equal(1, _fizzBuzzer.FizzCount);
            Assert.Equal(1, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            _fizzBuzzer.Check(3);

            Assert.Equal(2, _fizzBuzzer.FizzCount);
            Assert.Equal(2, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            _fizzBuzzer.Check(1);

            Assert.Equal(2, _fizzBuzzer.FizzCount);
            Assert.Equal(3, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);
        }
    }

    [Trait("FizzBuzzer Logic", "Buzz Numbers")]
    public class BuzzLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Check Returns Buzz given a Buzz value")]
        [InlineData(5)]
        [InlineData(35)]
        [InlineData(95)]
        public void FizzBuzzer_ReturnsBuzz_GivenABuzzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("Buzz", response);
        }
    }

    [Trait("FizzBuzzer Logic", "FizzBuzz Numbers")]
    public class FizzBuzzLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Check Returns FizzBuzz given a FizzBuzz value")]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(60)]
        public void FizzBuzzer_ReturnsFizzBuzz_GivenAFizzBuzzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("FizzBuzz", response);
        }
    }
}
