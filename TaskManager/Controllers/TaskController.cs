﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [Route("api/Tasks")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // GET: api/Task
        [HttpGet]
        [RequireHttps]
        public IEnumerable<Models.Task> Get()
        {
            return new Models.Task[] {
                new Models.Task() { id= 1, name= "task1" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
                new Models.Task() { id= 2, name= "task2" , startDate =DateTime.Today.AddMonths(-1), endDate = DateTime.Today.AddMonths(2), status = "progress", assignedTo=1},
            };
        }

        // GET: api/Task/5
        [HttpGet("{id}")]
        public IEnumerable<Models.Company> Get(int id)
        {
            //Company c;
            //c.email = "Adfa";
            var result = new List<Company>()
            {
                                    new Company  {  id=7,  name= "Computas", phone= "0948554224", email= "computas@gmail.com"},
                                    new Company    { id= -2, name= "SSW Brisbane", phone= "222", email= "brisbane@ssw.com.au"},
                                    new Company  { id= -3, name= "SSW Melbourne", phone= "", email= "melbourne@ssw.com.au"}    };
            return result;

        }

       
    }
}
