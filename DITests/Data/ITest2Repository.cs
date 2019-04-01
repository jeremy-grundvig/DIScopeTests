namespace DITests.Data
{
    public interface ITest2Repository
    {
        string Get();
    }

    public class Test2Repository : ITest2Repository
    {
        public static int Counter { get; private set; }

        public Test2Repository()
        {
            Counter++;
        }

        public string Get()
        {
            return $"Repo Counter: {Counter};Target: Test2";
        }
    }
}
