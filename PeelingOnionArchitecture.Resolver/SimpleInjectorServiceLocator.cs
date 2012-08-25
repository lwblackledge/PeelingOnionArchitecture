using System;
using System.Collections.Generic;
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
			catch( ActivationException )
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
			catch( ActivationException )
			{
				return null;
			}
		}

		public IEnumerable<T> GetAll<T>() where T : class
		{

			return _container.GetAllInstances<T>();

		}

		public IEnumerable<object> GetAll( Type type )
		{
			return _container.GetAllInstances( type );
		}
	}
}
