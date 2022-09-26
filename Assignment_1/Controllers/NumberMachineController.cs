using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// step 1) input adds 10
        /// step 2) 5 subtracted form step 1 result
        /// step 3) 10 multiplied from step 2 result
        /// step 4) step 3 result divided by 2
        /// step 4 result is final result
        /// </summary>
        /// <param name="id">number on which arithmatic operation will be performed</param>
        /// <returns>performs four arithmatic operations on the input</returns>
        /// <example>
        /// Get  /api/NumberMachine/22   ->135
        /// </example>
        public int Get(int id)
        {
            int addition = id + 10;
            int subtraction = addition - 5;
            int multiply = subtraction * 10;
            int quotient = multiply / 2;
            return quotient;
        }
    }
}