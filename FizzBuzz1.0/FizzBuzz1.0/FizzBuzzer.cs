using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public int FizzCount { get; set; }
        public int BuzzCount { get; set; }
        public int FizzBuzzCount { get; set; }
        public int TotalCount { get; set; }

        public string Check(int value)
        {
            TotalCount++;
            return "";
        }
    }
}
