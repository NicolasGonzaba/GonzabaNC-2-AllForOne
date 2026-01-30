using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(int num)
        {
            if (num % 2 == 0)
            { return $"{num} is even."; }
            else
            { return $"{num} is odd."; }
        }
    }
}