using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class AskingQuestionsService
    {
        public string NameTime(string userName, string userTime)
        {
            return $"Hello {userName}! You woke up at {userTime} today.";
        }
    }
}