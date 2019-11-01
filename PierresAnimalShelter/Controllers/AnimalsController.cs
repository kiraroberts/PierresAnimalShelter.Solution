using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PierresAnimalShelter.Models;

namespace PierresAnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private PierresAnimalShelterContext _db;
        public AnimalsController(PierresAnimalShelterContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _db.Animals.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
        }
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }
    }
}