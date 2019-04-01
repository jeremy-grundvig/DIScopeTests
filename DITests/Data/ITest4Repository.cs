namespace DITests.Data
{
    public interface ITest4Repository
    {
        string Get();
    }

    public class Test4Repository : ITest4Repository
    {
        public static int Counter { get; private set; }

        public Test4Repository()
        {
            Counter++;
        }

        public string Get()
        {
            return $"Repo Counter: {Counter};Target: values";
        }
    }
}
