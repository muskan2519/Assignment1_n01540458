using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01540458.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// returns => array of strings showing total cost of FN, total HST, final cost
        /// </summary>
        /// <param name="id">Results an array of strings showing total cost of FN, total HST, final cost</param>
        /// <returns>
        /// {total number of FN} fortnights at $5.50/FN = ${total cost}CAD
        /// HST 13% = ${total HST}CAD
        /// Total = ${final cost of FN}CAD
        /// </returns>
        /// GET /api/HostingCost/{id}
        /// <example>
        /// /api/NumberMachine/0
        /// <returns>
        /// 1 fortnights at $5.50/FN = $5.5 CAD
        /// HST 13% = $0.715 CAD
        /// Total = $6.215 CAD
        /// </returns>
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int numberOfFortnights = (id / 14) + 1;
            double oneFNCost = 5.50;
            double hst = 0.13;
            double totalCost = numberOfFortnights * oneFNCost;
            double hstForFN = hst * totalCost;
            double finalCost = totalCost + hstForFN;
            return new string[] { numberOfFortnights+" fortnights at $5.50/FN = $"+totalCost+" CAD", "HST 13% = $" + hstForFN + " CAD", "Total = $"+finalCost+" CAD" };
        }
    }
}
