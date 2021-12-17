using System.Collections.Generic;
using ShelterCollection.Data;

namespace ShelterCollection.Repositories
{
    public interface IDogsRepository
    {
        List<Dog> GetDogs();
        void CreateDogs(Dog dog);
        Dog GetDog(int id);
        void UpdateDog(Dog dog);

        void DeleteDog(int id);


    }
}