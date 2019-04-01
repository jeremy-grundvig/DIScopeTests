namespace DITests.Data
{
    public interface ITest5Repository
    {
        string Get();
    }

    public class Test5Repository : ITest5Repository
    {
        public static int Counter { get; private set; }

        public Test5Repository()
        {
            Counter++;
        }

        public string Get()
        {
            return $"Repo Counter: {Counter};Target: values";
        }
    }
}
