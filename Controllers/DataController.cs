using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// using HomeAutomation.Controllers;
using HomeAutomation.Models;

namespace HomeAutomation.Controllers
{
    [Produces("application/json")]

    // Possibly change the route to api/homes/{id}/data. Could maybe be done in startup.cs instead?
    // Remember to: 
    // Change properties for Launch URL
    // Change deployment from Development to Production
    // GET /homes/{id}/data d�r {id} �r en dynamisk identifierare f�r ett hus, t.ex. "hus1". URL:en blir d� /homes/hus1/data.

    [Route("api/v1/homes/{id}/data")]
    //[Route("api/homes/{id?}/Data")]

    public class DataController : Controller
    {

        //private static List<Room> _room = new List<Room>(new[]
        //{
        //    new Room() {}
        //});

        private static List<Data> _data = new List<Data>(new[] {
                new Data() {name = "Barnrum"},
                new Data() {name = "Lekrum"},
                new Data() {name = "K�k"},
                new Data() {name = "Sovrum"},
                new Data() {name = "Vardagsrum"},
                new Data() {name = "Balkong"}
            });


        // Add the the rooms to one list. WHY??? Think of a reason. Does the program need to be restructured?
        // MUST CREATE A CLASS FOR ROOMS?

        //private static List<rooms> = new List<rooms>(new[] {
        //        new rooms() { data }
        //    });

        // Make it possible to access a specific home resource
        [HttpGet]
        public List<Data> Get()
        {
            return _data;
        }

        // Add new data from post
        [HttpPost]
        public IActionResult Post([FromBody]Data data)
        {
            return Json(data);
//            _data.Add(data);
//            return CreatedAtAction(nameof(Get), new { id = home.ID }, home);
        }

        /* Should be able to:
        * GET data for a single house
        * POST or PUT data for a single house
        * DELETE data for a single house
        * REMEMBER TO DEAL WITH ERRORS! EI. FAILURE TO GET, PUT OR DELETE
        */

        /* Add [REQUIRED] to POST method 
        * if(!ModelState.IsValid)
        * {
        *   return BadRequest();
        * }
        * */

    }
}