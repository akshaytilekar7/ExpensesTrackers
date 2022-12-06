namespace ExpenseTracker.Core
{
    public interface IMyConfig
    {
        string Environment { get; set; }
        bool UseDatabaseDummy { get; set; }
    }

    public class MyConfig : IMyConfig
    {
        public string Environment { get; set; }
        public bool UseDatabaseDummy { get; set; }

    }
}
