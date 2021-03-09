namespace InterfaceDemo
{
    class FileDataAccess : IDataAccess
    {
        string filePath;
        string fileData;

        public FileDataAccess()
        {

        }

        public FileDataAccess(string path)
        {
            filePath = path;
        }

        public string Data { get => fileData; }
        // public string Data  => fileData;

        public void GetData()
        {
            fileData = "file data";
        }
        //a method to get data from file
        //GetData()
    }
}