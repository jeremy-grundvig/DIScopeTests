using DITests.Data;

namespace DITests.Services
{
    public interface ITest1Service
    {
        string Get();
    }

    public class Test1Service : ITest1Service
    {
        private readonly ITest1Repository _test1Repository;
        public static int Counter { get; private set; }

        public Test1Service(ITest1Repository test1Repository)
        {
            _test1Repository = test1Repository;
            Counter++;
        }

        public string Get()
        {
            return $"Service Counter: {Counter};{_test1Repository.Get()}";
        }
    }
}
