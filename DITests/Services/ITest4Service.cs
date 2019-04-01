using DITests.Data;

namespace DITests.Services
{
    public interface ITest4Service
    {
        string Get();
    }

    public class Test4Service : ITest4Service
    {
        private readonly ITest4Repository _valueRepository;
        public static int Counter { get; private set; }

        public Test4Service(ITest4Repository valueRepository)
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
