using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Массивы.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassivController : ControllerBase
    {
        //1
        [HttpPost("ComplexValue3/{k}")]
        public int GetRandomTestData2(int[] massiv, int k)
        {

            int sum = massiv.Where(s => s % k == 0).Sum();
            return sum;

        }

        //2
        [HttpPost("ComplexValue4")]
        public int[] GetRandomTestData2(int[] massiv)
        {

            int nulli = massiv.Count(s => s == 0);

            int[] nulll = new int [nulli];
            int g = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] == 0)
                {
                    nulll[g] = i;
                    g++;
                }
            }
            return nulll;

        }

        //3
        [HttpPost("ComplexValue5")]
        public bool GetRandomTestData3(int[] massiv)
        {
            
            bool Minus = massiv.First() < 0;
            
            return Minus;
        }

        //4
        [HttpPost("ComplexValue6")]
        public bool GetRandomTestData4(int[] massiv)
        {
            int i = massiv.First();
            foreach(int ii in massiv)
            {
                if (ii >= i)
                    i = ii;
                else
                    return false;
            }
            return true;
        }

        //5
        [HttpPost("ComplexValue7")]
        public int[] GetRandomTestData7(int[] massiv)
        {
            int[] Chet = massiv.Where(s => s % 2 == 0).ToArray();

            return Chet;
        }

        //6
        [HttpPost("ComplexValue8")]
        public int GetRandomTestData8(int[] massiv)
        {
            int Razn = massiv.Max() - massiv.Min();


            return Razn;
        }

        //7
        [HttpPost("ComplexValue9")]
        public int GetRandomTestData9(int[] massiv)
        {
            int[] Chet = massiv.Where(s => s % 2 == 0).ToArray();


            return Razn;
        }
    }
}
