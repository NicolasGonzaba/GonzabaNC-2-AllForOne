using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ReverseAlphaNumService
    {
        public string ReverseAlphaNum(string LetterNum)
        {
            string ReversedLetterNum = "";
            
            for (int i = LetterNum.Length - 1; i >= 0; i--)
            {
                ReversedLetterNum += LetterNum[i].ToString();
            }
            return $"The reverse of {LetterNum} is {ReversedLetterNum}.";
        }

    }
}