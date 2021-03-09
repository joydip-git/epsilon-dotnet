namespace InterfaceDemo
{
    class DatabaseDataAccess : IDataAccess
    {
        string dbConnectionString;
        string dbData;
        public DatabaseDataAccess()
        {

        }
        public DatabaseDataAccess(string connectionSting)
        {
            dbConnectionString = connectionSting;
        }

        //no need of override keyword to implement interface members
        public string Data => dbData;
        // public string Data { get => dbData; }

        public void GetData()
        {
            dbData = "database data";
        }
        //a method to get data from a database
        //GetData()

    }
}