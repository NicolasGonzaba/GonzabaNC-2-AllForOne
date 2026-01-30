using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class GuessItService
    {
        public string EasyMode(int Guess)
        {
        Random random=new Random();
        int rng = random.Next(1, 11);
            if (Guess > 10 || Guess<1)
            {
                return "Please guess a number between 1 and 10";
            }else if (Guess == rng)
            {
                return $"The number was {rng}. You got it!";
            }else if (Guess > rng)
            {
                return $"Your guess was too high. The number was {rng}.";
            }
            return $"Your guess was too low. The number was {rng}.";
        }
        
        public string MediumMode(int Guess)
        {
        Random random=new Random();
        int rng = random.Next(1, 51);
            if (Guess > 50 || Guess<1)
            {
                return "Please guess a number between 1 and 50";
            }else if (Guess == rng)
            {
                return $"The number was {rng}. You got it!";
            }else if (Guess > rng)
            {
                return $"Your guess was too high. The number was {rng}.";
            }
            return $"Your guess was too low. The number was {rng}.";
        }

      
        public string HardMode(int Guess)
        {
        Random random=new Random();
        int rng = random.Next(1, 101);
            if (Guess > 100 || Guess<1)
            {
                return "Please guess a number between 1 and 100";
            }else if (Guess == rng)
            {
                return $"The number was {rng}. You got it!";
            }else if (Guess > rng)
            {
                return $"Your guess was too high. The number was {rng}.";
            }
            return $"Your guess was too low. The number was {rng}.";
        }
    }
}