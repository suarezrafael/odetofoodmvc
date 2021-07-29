using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Service
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>() { 
                new Restaurant{ Id = 1, 
                    Cuisine = CuisineType.Italian,
                    Name = "Pizza"}
            ,new Restaurant{ Id = 2,
                    Cuisine = CuisineType.French,
                    Name = "Tersiguels"}
            ,new Restaurant{ Id =3,
                    Cuisine = CuisineType.Indian,
                    Name = "Mango Grove"}
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r=>r.Name);
        }
    }
}
