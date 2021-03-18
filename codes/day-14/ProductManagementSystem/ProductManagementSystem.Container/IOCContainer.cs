using System;

namespace ProductManagementSystem.Container
{
    public class IOCContainer
    {
        public TInterface Create<TInterface, TClass>()
        {
            return (TInterface)Activator.CreateInstance(typeof(TClass));
        }
    }
}
