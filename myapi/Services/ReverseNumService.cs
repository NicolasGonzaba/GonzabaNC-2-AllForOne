using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ReverseNumService
    {
        public string ReverseNum(int digits)
        {
            string reverse="";
             for (int i =digits.ToString().Length - 1; i >= 0; i--)
                {
                    reverse +=digits.ToString()[i];
                }
                return $"The reverse of {digits} is {reverse}.";
        }
    }
}