using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SortingAlgorithms.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SortController : ControllerBase
    {
        private static int[] unsortedArray;

        private readonly ILogger<SortController> _logger;

        public SortController(ILogger<SortController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<int> Get(string size)
        {
            System.IO.File.WriteAllText(@"C:\Users\Kamil\Desktop\WriteText.txt", size);
            return Models.GenerateUnsortedArray.GenerateArray(20);
        }
    }
}