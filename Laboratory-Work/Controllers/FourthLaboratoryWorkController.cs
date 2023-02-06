
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Laboratory_Work.Classes.FourthLaboratoryWork;
using DecimalMath;

namespace Laboratory_Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FourthLaboratoryWorkController : ControllerBase
    {
        decimal Function2(decimal x)
        {

            decimal x3 = DecimalEx.Pow(x, 3);
            decimal x2 = DecimalEx.Pow(x, 2);

            return (2m * x3) - (5m * x2) + (4m * x) + 6m;
        }

        [HttpGet]
        public string Get( decimal a, decimal b, decimal precition)
        {

            LaboratoryWorkRespounse respounse = 
                Methods.MethodBisection(new Func<decimal, decimal>(Function2),a,b,precition);
            
            


            return JsonConvert.SerializeObject(respounse);
        }

    }
}
