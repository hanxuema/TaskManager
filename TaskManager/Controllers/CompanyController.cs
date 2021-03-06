﻿using System;
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
    [Route("api/Companies")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CompanyController : ControllerBase
    {

        ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Task
        [HttpGet]
        public IEnumerable<Models.Company> Get()
        {
            return db.Companies.ToList();
        }

        [HttpGet("{id}")]
        public Models.Company Get(int id)
        {
            return db.Companies.FirstOrDefault(t => t.id == id);

        }

        [HttpPost]
        public void Post([FromBody] TaskManager.Models.Company company)
        {
            db.Add(company);
            db.SaveChanges();
        }
    }
}
