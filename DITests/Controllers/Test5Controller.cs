using DITests.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test5Controller : ControllerBase
    {
        private readonly ITest5Service _valueService;
        public static int Counter { get; private set; }

        public Test5Controller(ITest5Service valueService)
        {
            _valueService = valueService;
            Counter++;
        }

        // GET api/values
        /// <summary>
        /// This method will succeed as the Service is Scoped and Repository is Singleton
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Controller Counter: {Counter};{_valueService.Get()}";
        }
    }
}
