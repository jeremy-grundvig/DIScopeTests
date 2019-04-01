namespace DITests.Data
{
    public interface ITest1Repository
    {
        string Get();
    }

    public class Test1Repository : ITest1Repository
    {
        public static int Counter { get; private set; }

        public Test1Repository()
        {
            Counter++;
        }

        public string Get()
        {
            return $"Repo Counter: {Counter};Target: Test1";
        }
    }
}
