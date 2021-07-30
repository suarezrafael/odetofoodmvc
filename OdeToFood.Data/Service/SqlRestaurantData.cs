using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Service
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }

        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from rest in db.Restaurants
                   orderby rest.Name
                   select rest;
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();

            //var existing = Get(restaurant.Id);

            //if (existing != null)
            //{
            //    existing.Name = restaurant.Name;
            //    existing.Cuisine = restaurant.Cuisine;
            //}
            //db.SaveChanges();
        }

        public void Delete(int id)
        {
            var existing = db.Restaurants.Find(id);

            if (existing != null)
            {
                db.Restaurants.Remove(existing);
            }
            db.SaveChanges();
        }
    }
}
