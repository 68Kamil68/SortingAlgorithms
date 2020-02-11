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
        private readonly ILogger<SortController> _logger;

        public SortController(ILogger<SortController> logger)
        {
            _logger = logger;
        }

        [HttpPost][Route("Generate")]
        public IEnumerable<int> Get([FromBody]string size)
        {
            System.IO.File.WriteAllText(@"C:\Users\Kamil\Desktop\WriteText.txt", size);
            return Models.GenerateUnsortedArray.GenerateArray(Int32.Parse(size));
        }

        [HttpPost]
        [Route("QuickSort")]
        public IEnumerable<int> QuickSort([FromBody]int[] array)
        {
            System.IO.File.WriteAllText(@"C:\Users\Kamil\Desktop\WriteText.txt", array.ToString());

            return Models.QuickSort.Sort(array);
        }

        [HttpPost]
        [Route("MergeSort")]
        public IEnumerable<int> MergeSort([FromBody]int[] array)
        {
            return Models.MergeSort.Sort(array);
        }

        [HttpPost]
        [Route("BubbleSort")]
        public IEnumerable<int> BubbleSort([FromBody]int[] array)
        {
            return Models.BubbleSort.Sort(array);
        }

        [HttpPost]
        [Route("SelectionSort")]
        public IEnumerable<int> SelectionSort([FromBody]int[] array)
        {
            return Models.SelectionSort.Sort(array);
        }
    }
}