using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ShelterCollection.Data;

namespace ShelterCollection.Repositories
{
    public class DogsRepository : IDogsRepository
    {
        private readonly List<Dog> _shelter = new()
        {
            new()
            {
                Id = 1,
                Name = "Gav Gav"
            },
            new()
            {
                Id = 2,
                Name = "Gav Gav 2"
            }
        };

        public void CreateDogs(Dog dog)
        {
            _shelter.Add(dog);
        }

        public List<Dog> GetDogs()
        {
            return _shelter;

        }

        public Dog GetDog(int id)
        {

            return _shelter.Where(d => d.Id == id).SingleOrDefault();
        }

        public void UpdateDog(Dog dog)
        {

            var dogItem = _shelter.Where(d => d.Id == dog.Id).SingleOrDefault();
            dogItem.Name = dog.Name;

            //  _shelter.SaveChanges();

        }

        public void DeleteDog(int id)
        {
            var dog = _shelter.Where(d => d.Id == id).SingleOrDefault();
            _shelter.Remove(dog);

        }



    }
}