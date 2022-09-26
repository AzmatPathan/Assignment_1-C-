using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// returns (input+10)
        /// </summary>
        /// <param name="id">Number which will get added by 10</param>
        /// <returns> input + 10</returns>
        /// Get /api/AddTen/{id}
        /// /api/AddTen/28
        /// </example>
        public int Get(int id)
        {
            int addedNumber = id + 10;
            return addedNumber;
        }
    }
}