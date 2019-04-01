namespace DITests.Data
{
    public interface ITest3Repository
    {
        string Get();
    }

    public class Test3Repository : ITest3Repository
    {
        public static int Counter { get; private set; }

        public Test3Repository()
        {
            Counter++;
        }

        public string Get()
        {
            return $"Repo Counter: {Counter};Target: values";
        }
    }
}
