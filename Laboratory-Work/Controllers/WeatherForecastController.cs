using Microsoft.AspNetCore.Mvc;
using Laboratory_Work.Classes.FirstlaboratoryWork;
namespace Laboratory_Work.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstLaboratoryWorkController : ControllerBase
    {
        

        [HttpGet]
        public string Get(double x)
        {

            return FunctionsVariant.VariantSix(x).ToString();
        }
    }
}