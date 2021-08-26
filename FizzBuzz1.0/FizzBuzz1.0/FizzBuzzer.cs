using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public FizzBuzzer()
        {
        }

        public int FizzCount { get; set; }
        public int BuzzCount { get; set; }
        public int FizzBuzzCount { get; set; }
        public int TotalCount { get; set; }

        public string Check(int value)
        {
            TotalCount++;

            if(value % 15 == 0)
            {
                FizzBuzzCount++;
                return "FizzBuzz";
            }
            if(value % 3 == 0)
            {
                FizzCount++;
                return "Fizz";
            }
            if (value % 5 == 0)
            {
                BuzzCount++;
                return "Buzz";
            }

            return value.ToString();
        }

        public void Check(List<int> values)
        {
            foreach (int value in values)
            {
                Check(value);
            }
        }
    }
}
