using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01540458.Controllers
{
    
    public class GreetingController : ApiController
    {
        public string Get()
        {
            return "Hello World!";
        }
        /// <summary>
        /// returns => "Hello World!"
        /// </summary>
        /// <param name="value">Results string - Hello World!</param>
        /// <returns>Hello World!</returns>
        /// POST /api/Greeting
        /// <example>
        /// /api/Greeting
        /// <returns>Hello World!</returns>
        /// </example>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// returns => "Greetings to {number of people} people!"
        /// </summary>
        /// <param name="id">Results string - Greetings to {id} people!</param>
        /// <returns>Greetings to {id} people!</returns>
        /// GET /api/Greeting/{id}
        /// <example>
        /// /api/Greeting/45
        /// <returns>Greetings to 45 people!</returns>
        /// </example>
        public string Get(int id)
        {
            string greetingPeople = "Greetings to " + id + " people!";
            return greetingPeople;
        }
    }
}
