using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeelingOnionArchitecture.Core;

namespace PeelingOnionArchitecture.Resolver
{
    public class SimpleInjectorServiceLocator : IServiceLocator
    {
        public T GetInstance<T>()
        {
            throw new NotImplementedException();
        }

        public object GetInstance(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
