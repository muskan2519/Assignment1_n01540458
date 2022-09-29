using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01540458.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// returns => userInput * userInput
        /// </summary>
        /// <param name="id">Result after multiplying the input to itself</param>
        /// <returns>userInput * userInput</returns>
        /// GET /api/Square/{id}
        /// <example>
        /// /api/Square/5
        /// <returns>25</returns>
        /// </example>
        public int Get(int id)
        {
            int squareNo = id * id;
            return squareNo;
        }
    }
}
