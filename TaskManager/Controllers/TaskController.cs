using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // GET: api/Task
        [HttpGet]
        public IEnumerable<Models.Task> Get()
        {
            return new Models.Task[] {
                new Models.Task() { id= 1, name= "task1" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
                new Models.Task() { id= 2, name= "task2" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
            };
        }

        // GET: api/Task/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
