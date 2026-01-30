using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace myapi.Services
{
    public class AddNumbersService
    {
        public string AddTwo(int num1, int num2)
        {
            int sum=num1+num2;
            return $"The sum of {num1} and {num2} is {sum}";
        }
    }
}