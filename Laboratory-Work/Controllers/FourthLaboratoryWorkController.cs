
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
        

        [HttpGet]
        public string Get( decimal a, decimal b, decimal precition)
        {

            LaboratoryWorkRespounse respounse = 
                Methods.MethodBisection(FunctionVariant.VariantSix,a,b,precition);
            
            


            return JsonConvert.SerializeObject(respounse);
        }

    }
}
