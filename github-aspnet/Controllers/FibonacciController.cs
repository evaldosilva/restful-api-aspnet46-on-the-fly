using github_aspnet.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace github_aspnet.Controllers
{
    public class FibonacciController : ApiController
    {
        // GET: api/Fibonacci
        public string Get()
        {
            return "This endpoint returns the Fibonacci sequence, from 0 to the level that you want.";
        }

        // GET: api/Fibonacci/5
        public IEnumerable<int> Get(int level)
        {
            return Fibonacci.CalculateFibonacci(level);
        }
    }
}