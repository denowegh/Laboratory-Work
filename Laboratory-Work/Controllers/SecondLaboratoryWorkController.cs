using Laboratory_Work.Classes.SecondLaboratoryWork;
using MathNet.Numerics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DecimalMath;
namespace Laboratory_Work.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SecondLaboratoryWorkController : ControllerBase
    {

        [HttpGet]
        public string Get(decimal A, decimal B, int N)
        {
            
            Func<decimal,decimal> func = FunctionsVariant.VariantSix;

            decimal S = NumericalIntegration.methodSimpson(func, A, B, N);
            decimal T = NumericalIntegration.methodTrapezium(func, A, B, N);
            
            LaboratoryWorkRespounse laboratoryWorkRespounse = new LaboratoryWorkRespounse();
            laboratoryWorkRespounse.ResultMethodTrapezium = NumericalIntegration.methodTrapezium(func, A, B, N);
            laboratoryWorkRespounse.ResultMethodSimpson = NumericalIntegration.methodSimpson(func, A, B, N);
            laboratoryWorkRespounse.Comparison = NumericalIntegration.Comparison(S, T);

            laboratoryWorkRespounse.N = N;
            laboratoryWorkRespounse.A = A;
            laboratoryWorkRespounse.B = B;
            string json = JsonConvert
                .SerializeObject(laboratoryWorkRespounse);
            return json;
        }
    }
}
