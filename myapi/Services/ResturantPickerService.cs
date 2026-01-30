using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ResturantPickerService
    {
        public string Picker(string Category)
    {
        string restaurant = Category.ToLower();
        Random rng = new Random();
        int choice = rng.Next(0, 10);
        if (restaurant == "mexican")
        {
            string[] mexican = ["Why not go to Chipotle!",
            "Why not go to Mi rachito Cafe!",
            "Why not go to Arroyo's cafe!",
            "Why not go to Xochimilco Cafe!",
            "Why not go to Tio Pepe's!",
            "Why not go to Las Palmas!",
            "Why not go to Casa Flores!",
            "Why not go to Alberto's Mexican Food!",
            "Why not go to El Grullito!",
            "Why not go to Tacos Chapala!"
            ];
            return mexican[choice];
        }
        else if (restaurant == "pizza")
        {
            string[] pizza = ["Why not go to Domino's",
            "Why not go to Mountain Mike's!",
            "Why not go to Pizza Guys!",
            "Why not go to Pizza Hut!",
            "Why not go to Round Table!",
            "Why not go to Eddie's Pizza!",
            "Why not go to Little Ceaser's!",
            "Why not go to Papa John's!",
            "Why not go to Papa Murphy's!",
            "Why not go to Pizza Twist!"
            ];
            return pizza[choice];
        }
        else if (restaurant == "fast food")
        {
            string[] fastFood = ["Why not go to McDonalds!",
            "Why not go to Wendy's!",
            "Why not go to In-N-Out!",
            "Why not go to Chick-fil-a!",
           "Why not go to Jack in the Box!",
            "Why not go to Burger King!",
            "Why not go to Popeyes!",
            "Why not go to el Pollo Loco!",
           "Why not go to Taco Bell!",
            "Why not go to Raising Cane's!"
            ];
            return fastFood[choice];
        }
        return "Please choose a category between 'Mexican','Pizza', or 'Fast Food'";
    }
    }
}