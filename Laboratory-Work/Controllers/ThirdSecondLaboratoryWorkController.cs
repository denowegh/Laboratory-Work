using Laboratory_Work.Classes.SecondLaboratoryWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Laboratory_Work.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThirdSecondLaboratoryWorkController : ControllerBase
    {
        [HttpGet]
        public string Get(double x)
        {
            return "tttt";
        }
    }
}
