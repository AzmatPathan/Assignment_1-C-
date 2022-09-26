using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// returns Hello World! without any parameter
        /// </summary>
        /// <returns>Hello World!</returns>
        /// <example>
        /// Post /api/Greeting   ->Hello World!
        /// </example>
       

        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// returns statement (Greetings to {id} people!)
        /// </summary>
        /// <param name="id">Number of people</param>
        /// <returns>Greetings to {id} people!</returns>
        /// <example>
        /// Post   /api/Greeting/4    -> Greetings to 4 people!
        /// </example>
        public string Post(int id)
        {
            string finalString = "Greetings to " + id + " people!";
            return finalString;
        }
    }
}