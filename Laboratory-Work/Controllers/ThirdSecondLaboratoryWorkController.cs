using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Drawing;
using static Laboratory_Work.Classes.ThirdLaboratoryWork.FunctionsVariant;
using static Laboratory_Work.Classes.ThirdLaboratoryWork.NumericalIntegration;
using  Laboratory_Work.Classes.ThirdLaboratoryWork;
namespace Laboratory_Work.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThirdSecondLaboratoryWorkController : ControllerBase
    {
        [HttpGet]
        public string Get(decimal a,decimal b ,decimal n,int sampleSize)
        {
            LaboratoryWorkRespounse workRespounse = new LaboratoryWorkRespounse(a,b,n,sampleSize);


            workRespounse.Average = Average(workRespounse.Squeres);
            Console.WriteLine("average: {0}", workRespounse.Average);

            workRespounse.StandartDeviation = StandartDeviation(workRespounse.Squeres, workRespounse.Average);
            Console.WriteLine("standartDeviation: {0}", workRespounse.StandartDeviation);

            workRespounse.ConfidenceInterval = ConfidenceInterval(5, workRespounse.StandartDeviation);
            Console.WriteLine("confidenceInterval: {0}", workRespounse.ConfidenceInterval);

           

            workRespounse.ReliableSampleResult= ReliableSampleResult(workRespounse.Average, workRespounse.ConfidenceInterval);
            Console.WriteLine("Plus: {0}, Minus: {1}", workRespounse.ReliableSampleResult[0], workRespounse.ReliableSampleResult[1]);

            string strReturn = JsonConvert.SerializeObject(workRespounse);
            return strReturn;
        }
    }
}
