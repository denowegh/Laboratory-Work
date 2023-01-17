using Microsoft.AspNetCore.Mvc;
using Laboratory_Work.Classes.FirstlaboratoryWork;
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
            decimal[] decimals= new decimal[] { 5m,6m,3m};
            var Resp = new LaboratoryWorkRespounse(0.4216m, 0.0217m);
            
            string json = JsonConvert
                .SerializeObject(Resp);

            var person2 = JsonConvert.DeserializeObject<LaboratoryWorkRespounse>(json);

            return json;
        }
    }
}