using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[Controller]")]
    public class PersonsController : Controller
    {
        private D__RANDYFAMADOR_API_TRAINING_SAMPLEDB_MDFContext _context;

        public PersonsController(D__RANDYFAMADOR_API_TRAINING_SAMPLEDB_MDFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Person> getAllPerson()
        {
            var result = _context.Person.ToList();
            return result;
        }

        [HttpGet("{id}")]
        public Person Get(int id)    
        {
            var result = _context.Person.Where(c => c.Id == id).FirstOrDefault();
            return result;
        }

        [HttpPost]
        public Person CreatePerson([FromBody]Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return person;
        }
       
        [HttpPut("{personId}")]
        public Person UpdatePerson(int personId, string firstname, string lastname, int age)
        {
            var person = _context.Person.Where(c => c.Id == personId).FirstOrDefault();
            person.Firstname = firstname;
            person.LastName = lastname;
            person.Age = age;

            _context.Person.Update(person);
            _context.SaveChanges();
            return person;
        }

        [HttpDelete("{personId}")]
        public string DeletePerson(int personId)
        {
            var record = _context.Person.Where(c => c.Id == personId).FirstOrDefault();

            _context.Person.Remove(record);
            _context.SaveChanges();
            return "Deleted!";
        }
    }
}
