using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShelterCollection.Data;
using ShelterCollection.Repositories;

namespace ShelterCollection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogsController : ControllerBase
    {
        private readonly IDogsRepository _repository;
        public DogsController(IDogsRepository repo)
        {
            _repository = repo;
        }
        [HttpGet]

        public ActionResult<List<Dog>> GetDogs()
        {

            return Ok(_repository.GetDogs());
        }

        [HttpPost]


        public ActionResult<Dog> CreateDog(Dog dog)
        {
            _repository.CreateDogs(dog);
            return CreatedAtAction(nameof(GetDog), new { id = dog.Id }, dog);
        }

        [HttpGet("{id}")]


        public ActionResult<Dog> GetDog(int id)
        {
            var dog = _repository.GetDog(id);
            if (dog != null)
            {
                return Ok(dog);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]

        public ActionResult UpdateItem(Dog dog, int id)
        {
            var existingDog = _repository.GetDog(id);

            if (existingDog != null)
            {


                existingDog.Name = dog.Name;
                _repository.UpdateDog(existingDog);


                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteDog(int id)
        {
            var dogItem = _repository.GetDog(id);
            if (dogItem != null)
            {
                _repository.DeleteDog(dogItem.Id);
                return Ok("Dog successfuly deleted!");
            }
            else
            {
                return NotFound();
            }





        }

    }
}