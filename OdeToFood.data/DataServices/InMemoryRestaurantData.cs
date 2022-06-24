using OdeToFood.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.data.DataServices
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{id = 1, name = "Proud's Restuarant", cuisine =  CuisineType.French},
                new Restaurant{id = 2, name = "Pizza Hut", cuisine =  CuisineType.Italian},
                new Restaurant{id = 3, name = "Indian Baby", cuisine =  CuisineType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.name);
        }
    }
}
