using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratory_Work.Classes.FifthLaboratoryWork;
using Newtonsoft.Json;
namespace Laboratory_Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FifthLaboratoryWorkController : ControllerBase
    {


        [HttpGet]
        public string Get(decimal presition,decimal XFirst)
        {

            decimal[] arr = Methods.FindA_And_B(FunctionVariant.FunctionDecimal, XFirst, 2m);


            var resp = Methods.MethodOfSuccesApprox(FunctionVariant.FunctionDecimal,FunctionVariant.FunctionDouble,
                arr[0], arr[1], presition);
            string stringRespounse = JsonConvert.SerializeObject(resp);

            return stringRespounse;
        }




    }
}
