using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pop.BusinessLogic;

namespace Pop.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ValueGenerater _valueGenerator = new ValueGenerater();
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await _valueGenerator.GetAllValue();
            return result;
        }
    }
}