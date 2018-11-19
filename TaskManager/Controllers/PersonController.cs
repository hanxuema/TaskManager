using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DB;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [Route("api/Persons")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class PersonController : ControllerBase
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return db.Persons.ToList();
        }

        // GET: api/Task/5
        [HttpGet("{id}")]
        public Models.Person Get(int id)
        {
            return db.Persons.FirstOrDefault(t => t.id == id);

        }

        [HttpPost]
        public void Post([FromBody] TaskManager.Models.Person person)
        {
            db.Add(person);
            db.SaveChanges();
        }
    }
}
