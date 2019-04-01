using DITests.Data;

namespace DITests.Services
{
    public interface ITest2Service
    {
        string Get();
    }

    public class Test2Service : ITest2Service
    {
        private readonly ITest2Repository _test2Repository;
        public static int Counter { get; private set; }

        public Test2Service(ITest2Repository test2Repository)
        {
            _test2Repository = test2Repository;
            Counter++;
        }

        public string Get()
        {
            return $"Service Counter: {Counter};{_test2Repository.Get()}";
        }
    }
}
