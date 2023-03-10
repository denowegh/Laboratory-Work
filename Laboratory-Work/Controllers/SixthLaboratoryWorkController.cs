using Laboratory_Work.Classes.SixthLaboratoryWork;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace Laboratory_Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SixthLaboratoryWorkController : ControllerBase
    {
        [HttpGet]
        public string Get(decimal a, decimal b, decimal x0, decimal y0, decimal h,int n)
        {
            var func = new Func<decimal, decimal, decimal>(FunctionVariant.SixthVariant);
            
            LaboratoryWorkRespounse respounse = Methods.MethodEller(func,a, b, x0, y0, h,n);
            string ret = JsonConvert.SerializeObject(respounse);
            Console.WriteLine(respounse.ToString());
            return ret;
        }
    }
}
