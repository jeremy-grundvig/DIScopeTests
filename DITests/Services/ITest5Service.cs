using DITests.Data;

namespace DITests.Services
{
    public interface ITest5Service
    {
        string Get();
    }

    public class Test5Service : ITest5Service
    {
        private readonly ITest5Repository _valueRepository;
        public static int Counter { get; private set; }

        public Test5Service(ITest5Repository valueRepository)
        {
            _valueRepository = valueRepository;
            Counter++;
        }

        public string Get()
        {
            return $"Service Counter: {Counter};{_valueRepository.Get()}";
        }
    }
}
