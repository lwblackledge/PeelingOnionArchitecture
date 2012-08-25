using System;
using System.Collections.Generic;

namespace PeelingOnionArchitecture.Core
{
	public interface IServiceLocator
	{
		T GetInstance<T>() where T : class;
		object GetInstance( Type type );
		IEnumerable<T> GetAll<T>() where T : class;
		IEnumerable<object> GetAll( Type type );
	}

	public static class ServiceLocator
	{
		private static IServiceLocator _current;
		public static IServiceLocator Current
		{
			get
			{
				return _current;
			}
		}

		public static void SetServiceLocator( Func<IServiceLocator> create )
		{
			if( create == null )
			{
				throw new ArgumentNullException( "create" );
			}
			_current = create.Invoke();
		}
	}
}
