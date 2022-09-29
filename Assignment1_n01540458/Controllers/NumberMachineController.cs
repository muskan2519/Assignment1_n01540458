using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assignment1_n01540458.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// returns => 1stOperationResult, 2ndOperationResult, 3rdOperationResult, 4thOperationResult
        /// </summary>
        /// <param name="id">Results a string displaying 4 mathematical operations' outputs seperated by commas</param>
        /// <returns>1stOperationResult, 2ndOperationResult, 3rdOperationResult, 4thOperationResult</returns>
        /// GET /api/NumberMachine/{id}
        /// 1st Operation => (id+10)*11
        /// 2nd Operation => id-10
        /// 3rd Operation => id*5
        /// 4th Operation => id*id*id
        /// <example>
        /// /api/NumberMachine/10
        /// <returns>220, 0, 50, 1000</returns>
        /// </example>
        /// <example>
        /// /api/NumberMachine/5
        /// <returns>165, -5, 25, 125</returns>
        /// </example>
        public string Get(int id)
        {
            int firstOperation = (id + 10) * 11;
            int secondOperation = id - 10;
            int thirdOperation = id * 5;
            int fourthOperation = id * id * id;
            string result = "Results of the 4 mathematical operations are: " + firstOperation + ", " + secondOperation + ", " + thirdOperation + ", " + fourthOperation;
            return result;
        }

    }
}
