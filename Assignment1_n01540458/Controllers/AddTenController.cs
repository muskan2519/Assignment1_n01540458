using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01540458.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// returns => userInput + 10
        /// </summary>
        /// <param name="id">Result after adding 10 to user input</param>
        /// <returns>userInput + 10</returns>
        /// GET /api/AddTen/{id}
        /// <example>
        /// /api/AddTen/54 
        /// <returns>64</returns>
        /// </example>
        public int Get(int id)
        {
            int addTenNo = id + 10;
            return addTenNo;
        }
    }
}
