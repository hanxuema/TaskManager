using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [Route("api/Companies")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CompanyController : ControllerBase
    {
        // GET: api/Task
        [HttpGet]
        public IEnumerable<Models.Company> Get()
        {
            var result = new List<Company>()
            {
                                    new Company  {  id=7,  name= "Computas", phone= "0948554224", email= "computas@gmail.com"},
                                    new Company    { id= -2, name= "SSW Brisbane", phone= "222", email= "brisbane@ssw.com.au"},
                                    new Company  { id= -3, name= "SSW Melbourne", phone= "", email= "melbourne@ssw.com.au"}    };
            return result;
        }
 
    }
}
