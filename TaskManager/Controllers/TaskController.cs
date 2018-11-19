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
    [Route("api/Tasks")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Task
        [HttpGet]
        [RequireHttps]
        public IEnumerable<Models.Task> Get()
        {
            return db.Tasks.ToList();
            //new Models.Task[] {
            //    new Models.Task() { id= 1, name= "task1" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
            //    new Models.Task() { id= 2, name= "task2" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
            //};
        }

        // GET: api/Task/5
        [HttpGet("{id}")]
        public Models.Task Get(int id)
        {
            //Company c;
            //c.email = "Adfa";
            return db.Tasks.FirstOrDefault(t => t.id == id);

        }

        [HttpPost]
        public void Post([FromBody] TaskManager.Models.Task task)
        {
            db.Add(task);
            db.SaveChanges();
        }
    }
}
