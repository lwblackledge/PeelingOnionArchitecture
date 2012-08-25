using System;
using PeelingOnionArchitecture.Core;
using SimpleInjector;

namespace PeelingOnionArchitecture.Resolver
{
   public class SimpleInjectorServiceLocator : IServiceLocator
   {
      private readonly Container _container;

      public SimpleInjectorServiceLocator( Container container )
      {
         _container = container;
      }

      public T GetInstance<T>() where T : class
      {
         try
         {
            return _container.GetInstance<T>();
         }
         catch( ActivationException aEx )
         {
            return default( T );
         }
      }

      public object GetInstance( Type type )
      {
         try
         {
            return _container.GetInstance( type );
         }
         catch( ActivationException aEx )
         {
            return null;
         }
      }
   }
}
