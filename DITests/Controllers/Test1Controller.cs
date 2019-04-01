using DITests.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        private readonly ITest1Service _test1Service;
        public static int Counter { get; private set; }

        public Test1Controller(ITest1Service test1Service)
        {
            _test1Service = test1Service;
            Counter++;
        }

        // GET api/values
        /// <summary>
        /// This call works as both the Service and Repository are registered as Singleton
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Controller Counter: {Counter};{_test1Service.Get()}";
        }
    }
}
