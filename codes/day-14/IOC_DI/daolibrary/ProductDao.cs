using System;

namespace daolibrary
{
    public interface IDao
    {
        string Get();
    }

    public class ProductDao : IDao
    {
        private string conStr;
        public ProductDao()
        {
            conStr = "";
            //CM.CS[""].CS
        }
        public string Get()
        {
            return "data";
        }
    }
}
