using DITests.Data;

namespace DITests.Services
{
    public interface ITest3Service
    {
        string Get();
    }

    public class Test3Service : ITest3Service
    {
        private readonly ITest3Repository _valueRepository;
        public static int Counter { get; private set; }

        public Test3Service(ITest3Repository valueRepository)
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
