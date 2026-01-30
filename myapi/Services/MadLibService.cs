using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class MadLibService
    {
         public string Madlib(string yourName, string mood, string food, string animal, string adjective, string item, string place, string activity)
        {
             return $"{yourName} woke up feeling very {mood}. They wanted to get eat some {food} so went out to go get some. But on the way they were suddenly stopped by a {adjective} {animal}. Thinking quickly they grabbed a {item} nearby and used it fend of the {animal}, driving it away. after that they felt tired so they went to the {place} to eat {food} and {activity}.";
        }
    }
}