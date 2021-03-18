using System.Diagnostics.Contracts;
using static System.Console;
using daolibrary;
using IOCContainer;

namespace client
{
    class Program
    {
        static IDao dao;

        // static Program()
        // {
        //     //dao = Container.Create();
        //     dao = Container.Create<IDao, ProductDao>();
        // }
        static void Main()
        {
            dao = Container.Create<IDao, ProductDao>();
            if (dao != null)
            {
                string data = dao.Get();
                WriteLine(data);
            }
        }
    }
}
