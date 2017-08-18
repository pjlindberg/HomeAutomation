using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeAutomation.Models;

namespace HomeAutomation.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/homes")]
    public class HomesController : Controller
    {
        // C# list
        // Using _ when defining the private member variable for a public property 
        private static List<Home> _homes = new List<Home>(new[] {
                new Home() { ID = "hus1"}
            });

        [HttpGet]
        public List<Home> Get()
        {
            return _homes; // Could pick this up from a database: dbcontext.Homes.List
        }

        // Make it possible to access a specific home resource
        [HttpGet("{id}")] // Captures route parameter
        public IActionResult Get(string id)
        {
            var submittedHomeId = _homes.SingleOrDefault(home => home.ID == id);

            if(submittedHomeId == null)
            {
                return NotFound();
            }

            return Ok(submittedHomeId);
        }
        
        // Creat a new home using post
        [HttpPost]
        public IActionResult Post([FromBody]Home home)
        {
            _homes.Add(home);
            return CreatedAtAction(nameof(Get), new { id = home.ID }, home);
        }
    }
}