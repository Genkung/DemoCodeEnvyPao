using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ConsecutiveController : Controller
    {
        Consecutive svc;

        // GET api/values
        [HttpGet("{sum}")]
        public double[] CalculateFromSum(double sum)
        {
            svc = new Consecutive();
            var result = svc.ConsecutiveFromSum(sum);
            return result;
        }
    }
}