using Microsoft.AspNetCore.Mvc;
using Laboratory_Work.Classes.FirstlaboratoryWork;
using MathNet.Numerics;
using System.Xml.Linq;
using Newtonsoft.Json;
namespace Laboratory_Work.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstLaboratoryWorkController : ControllerBase
    {
        

        [HttpGet]
        public string Get(double x)
        {
            //Створення і заповнення обєкта відповіді 
            const decimal X0 = 0.4216m;

            var Resp = new LaboratoryWorkRespounse(X0, 0.0217m);

            Func<double, double> func = FunctionsVariant.VariantSix;

            Resp.A5Value = DerivativeFormulas.fivePointSchemeForCalculatingTheCostA(Resp.X, Resp.H, func);

            Resp.B5Value = DerivativeFormulas.fivePointSchemeForCalculatingTheCostB(Resp.X, Resp.H, func);

            Resp.DerivativeValue = (decimal)Differentiate.Derivative(func,(double)X0,1);

            Resp.SecondDerivative = DerivativeFormulas.FunctionForSerchingSecondDerivative(Resp.X, Resp.H, func);


            string json = JsonConvert
                .SerializeObject(Resp);

            var person2 = JsonConvert.DeserializeObject<LaboratoryWorkRespounse>(json);


            
            return json;
        }
    }
}