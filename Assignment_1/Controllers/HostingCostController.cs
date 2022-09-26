using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// step 1) fortnight count calculated
        /// step 2) cost calculated as per fotnight
        /// step 3) Tax added to the cost
        /// </summary>
        /// <param name="id">Number of days</param>
        /// <returns>Calculates hosting cost including the tax</returns>
        /// <example.
        /// GET /api/HostingCost/0  ->
        /// <string>1 fortnights at $5.50/FN = $ 5.5 CAD</string>
        ///<string>HST 13% = $0.72 CAD</string>
        ///<string>Total = $6.22 CAD</string>
        /// </example>


        public IEnumerable<string> Get(int id)
        {
            //fortnight count calculated
            double fortnightCount = (id / 14)+1;

            //assigned variable for fortnight cost
            double fortnightCost = 5.50;

            //cost calculated per fortnisht 
            double totalCostWithoutTax = fortnightCost * fortnightCount ;

            //total cost with tax
            double totalCost = 1.13 * totalCostWithoutTax;

            double totalTax = 0.13 * totalCostWithoutTax;

            IEnumerable<string> finalString = new String[]{ 
                fortnightCount + " fortnights at $5.50/FN = $ "+Math.Round(totalCostWithoutTax,2)  +" CAD",
                "HST 13% = $"+Math.Round(totalTax,2)+" CAD",
                "Total = $" + Math.Round(totalCost, 2) + " CAD"};

            return finalString;
        }
    }
}