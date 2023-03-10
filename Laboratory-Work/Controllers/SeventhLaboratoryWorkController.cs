using Laboratory_Work.Classes.SeventhLaboratoryWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Laboratory_Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeventhLaboratoryWorkController : ControllerBase
    {

        [HttpGet]
        public string Get(decimal a, decimal b, decimal x0, decimal y0, decimal h, int n)
        {

            var func = new Func<decimal, decimal, decimal>(FunctionVariant.FunctionVariantSix);

            LaboratoryWorkRespounse respounse = Methods.MethodRungeKutti(func, a, b, x0, y0, h, n);
            string ret = JsonConvert.SerializeObject(respounse);
            Console.WriteLine(respounse.ToString());
            return ret;
        }
    }
}
