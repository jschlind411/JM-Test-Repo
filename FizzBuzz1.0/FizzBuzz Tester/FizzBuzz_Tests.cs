using System;
using Xunit;
using FizzBuzz;
using System.Collections.Generic;

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
        public void NewFizzBuzzer_IsCreated_WithCorrectDefaults()
        {
            Assert.NotNull(_fizzBuzzer);

            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            Assert.Equal(0, _fizzBuzzer.TotalCount);
        }

        [Fact(DisplayName = "Can take list of ints and set correct counts")]
        public void NewFizzBuzzer_CanTakeListOfNumbersWhenCreated_AndReturnCorrectCounts()
        {
            var ListOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            _fizzBuzzer = new FizzBuzzer(ListOfNumbers);
            
            Assert.NotNull(_fizzBuzzer);

            Assert.Equal(4, _fizzBuzzer.FizzCount);
            Assert.Equal(2, _fizzBuzzer.BuzzCount);
            Assert.Equal(1, _fizzBuzzer.FizzBuzzCount);

            Assert.Equal(15, _fizzBuzzer.TotalCount);
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

        [Theory(DisplayName = "Checked Number should be returned if not a fizz/buzz/fizzbuzz Value")]
        [InlineData(4)]
        [InlineData(17)]
        [InlineData(53)]
        public void FizzBuzzer_ReturnsNumber_IfNot_Fizz_Buzz_FizzBuzz(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            int.TryParse(response, out var numberToCheck);

            Assert.Equal(valueToCheck, numberToCheck);
        }
    }

    [Trait("FizzBuzzer Logic", "Fizz Numbers")]
    public class FizzLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Check Returns Fizz given a Fizz Value")]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(36)]
        public void FizzBuzzer_ReturnsFizz_GivenAFizzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("Fizz", response);
        }

        [Fact(DisplayName = "Correctly Iterates Counts with Fizz Values")]
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
        [Theory(DisplayName = "Check Returns Buzz given a Buzz Value")]
        [InlineData(5)]
        [InlineData(35)]
        [InlineData(95)]
        public void FizzBuzzer_ReturnsBuzz_GivenABuzzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("Buzz", response);
        }

        [Fact(DisplayName = "Correctly Iterates Counts with Buzz Values")]
        public void FizzBuzzer_CorrectlyIteratesCounts_WhenCheckingBuzzValues()
        {
            _fizzBuzzer.Check(5);

            Assert.Equal(1, _fizzBuzzer.BuzzCount);
            Assert.Equal(1, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            _fizzBuzzer.Check(5);

            Assert.Equal(2, _fizzBuzzer.BuzzCount);
            Assert.Equal(2, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);

            _fizzBuzzer.Check(1);

            Assert.Equal(2, _fizzBuzzer.BuzzCount);
            Assert.Equal(3, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.FizzBuzzCount);
        }
    }

    [Trait("FizzBuzzer Logic", "FizzBuzz Numbers")]
    public class FizzBuzzLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Check Returns FizzBuzz given a FizzBuzz Value")]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(60)]
        public void FizzBuzzer_ReturnsFizzBuzz_GivenAFizzBuzzValue(int valueToCheck)
        {
            var response = _fizzBuzzer.Check(valueToCheck);

            Assert.Equal("FizzBuzz", response);
        }

        [Fact(DisplayName = "Correctly Iterates Counts with FizzBuzz Values")]
        public void FizzBuzzer_CorrectlyIteratesCounts_WhenCheckingFizzBuzzValues()
        {
            _fizzBuzzer.Check(15);

            Assert.Equal(1, _fizzBuzzer.FizzBuzzCount);
            Assert.Equal(1, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);

            _fizzBuzzer.Check(15);

            Assert.Equal(2, _fizzBuzzer.FizzBuzzCount);
            Assert.Equal(2, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);

            _fizzBuzzer.Check(1);

            Assert.Equal(2, _fizzBuzzer.FizzBuzzCount);
            Assert.Equal(3, _fizzBuzzer.TotalCount);
            Assert.Equal(0, _fizzBuzzer.FizzCount);
            Assert.Equal(0, _fizzBuzzer.BuzzCount);
        }
    }

    [Trait("FizzBuzzer Logic", "List Logic")]
    public class ListLogic : FizzBuzz_Tests
    {
        [Theory(DisplayName = "Can take a list of ints and set correct counts")]
        [InlineData?()]
        [ClassData?()]
        {MemberData?()]
        public void FizzBuzzer_CanTakeListOfNumbers_AndReturnCorrectCounts()
        {
            var ListOfNumbers = new List<int>();

            _fizzBuzzer.Check(ListOfNumbers);

            Assert.Equal(?, _fizzBuzzer.FizzCount);
            Assert.Equal(?, _fizzBuzzer.BuzzCount);
            Assert.Equal(?, _fizzBuzzer.FizzBuzzCount);

            Assert.Equal(?, _fizzBuzzer.TotalCount);
        }
    }
}
