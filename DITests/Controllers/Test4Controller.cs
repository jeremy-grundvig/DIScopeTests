using DITests.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test4Controller : ControllerBase
    {
        private readonly ITest4Service _valueService;
        public static int Counter { get; private set; }

        public Test4Controller(ITest4Service valueService)
        {
            _valueService = valueService;
            Counter++;
        }

        // GET api/values
        /// <summary>
        /// This method will succeed as the Service and Repository are Scoped
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Controller Counter: {Counter};{_valueService.Get()}";
        }
    }
}
