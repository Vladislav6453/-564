using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Массивы.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassivController : ControllerBase
    {
        [HttpPost("ComplexValue3/{k}")]
        public int GetRandomTestData2(int[] massiv, int k)
        {
            
            int sum = massiv.Where(s => s % k == 0).Sum();
            return sum;

        }
    }
}
