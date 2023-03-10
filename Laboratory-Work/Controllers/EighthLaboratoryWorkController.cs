using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratory_Work.Classes.EighthLaboratoryWork;
using Newtonsoft.Json;

namespace Laboratory_Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EighthLaboratoryWorkController : ControllerBase
    {
        [HttpGet]
        public string Get(decimal dX, decimal dT, decimal alpha)
        {
            var a = Methods.Method_Net(dX, FunctionVariant.Function_Variant_Six, dT, alpha,
                      FunctionVariant.Function_Variant_Six_boundaryCondition_X0,
                      FunctionVariant.Function_Variant_Six_boundaryCondition_X1);
            for (int i = 0; i < 725; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(" {0}",Math.Round( a[j, i]),2);
                }
                Console.WriteLine();
            }
            var resp = JsonConvert.SerializeObject(a);


            return resp;
        }
    }
}
