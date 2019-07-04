using OdeToFood.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Jack's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 1, Name = "King Kong Roll", Location = "California", Cuisine = CuisineType.Chinese},
                new Restaurant { Id = 1, Name = "Lindo's", Location = "Indiana", Cuisine = CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
