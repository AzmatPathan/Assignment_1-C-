using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// returns square of input
        /// </summary>
        /// <param name="id">number to get square of</param>
        /// <returns> input * input</returns>
        /// <example>
        /// Get  /api/Square/4  -> 16
        /// </example>
        public int Get(int id)
        {
            int square = id*id;
            return square;
        }
    }
}