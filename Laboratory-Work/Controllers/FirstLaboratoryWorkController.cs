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
        public string Get(decimal X0,decimal h)
        {
            //Створення і заповнення обєкта відповіді 
            

            var Resp = new LaboratoryWorkRespounse(X0, h);

            Func<double, double> func = FunctionsVariant.VariantSix;

            Resp.A5Value = DerivativeFormulas.fivePointSchemeForCalculatingTheCostA(Resp.X, Resp.H, func);

            Resp.B5Value = DerivativeFormulas.fivePointSchemeForCalculatingTheCostB(Resp.X, Resp.H, func);

            Resp.DerivativeValue = (decimal)Differentiate.Derivative(func,(double)X0,1);

            Resp.SecondDerivative = DerivativeFormulas.FunctionForSerchingSecondDerivative(Resp.X, Resp.H, func);


            string json = JsonConvert
                .SerializeObject(Resp);



            
            return json;
        }
    }
}