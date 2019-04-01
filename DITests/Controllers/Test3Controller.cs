using DITests.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test3Controller : ControllerBase
    {
        private readonly ITest3Service _valueService;
        public static int Counter { get; private set; }

        public Test3Controller(ITest3Service valueService)
        {
            _valueService = valueService;
            Counter++;
        }

        // GET api/values
        /// <summary>
        /// You would expect this method to fail since the Service is Singleton and the Repository is Transient, but no. It "works" with unintended consequences.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Controller Counter: {Counter};{_valueService.Get()}";
        }
    }
}
