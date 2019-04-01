using DITests.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        private readonly ITest2Service _test2Service;
        public static int Counter { get; private set; }

        public Test2Controller(ITest2Service test2Service)
        {
            _test2Service = test2Service;
            Counter++;
        }

        // GET api/values
        /// <summary>
        /// This method will fail as the Service is Singleton and Repository is Scoped
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Controller Counter: {Counter};{_test2Service.Get()}";
        }
    }
}
