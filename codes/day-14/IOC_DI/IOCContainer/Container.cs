using System;

namespace IOCContainer
{
    public class Container
    {
        // public static IDao Create()
        // {
        //     return new ProductDao();
        // }
        //private static Type clsType;
        //public static void Register<TInterface, TClass>()
        //{
        //    clsType = typeof(TClass);   
        //}
        //public static object Create()
        //{
        //    return Activator.CreateInstance(clsType);
        //}
        public static TInterface Create<TInterface, TClass>()
        {
            //return default(TInterface);
            //dynamically creating object
            return (TInterface)Activator.CreateInstance(typeof(TClass));
        }
    }
}
