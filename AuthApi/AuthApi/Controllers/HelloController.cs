using Core.Model.Dto.Concrete.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
        public ActionResult<HelloMessage> Hello()
        {

            return new HelloMessage() { Message = "Hello World!"};
        }


    }


}
