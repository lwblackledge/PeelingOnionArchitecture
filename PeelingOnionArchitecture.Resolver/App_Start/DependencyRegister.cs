using System.Web;
using PeelingOnionArchitecture.Core;
using PeelingOnionArchitecture.Core.Repositories;
using PeelingOnionArchitecture.Core.Services;
using PeelingOnionArchitecture.Infrastructure.Repositories;
using PeelingOnionArchitecture.Infrastructure.Services;
using SimpleInjector;

[assembly: PreApplicationStartMethod( typeof( PeelingOnionArchitecture.Resolver.App_Start.DependencyRegister ), "RegisterAllDependencies" )]
namespace PeelingOnionArchitecture.Resolver.App_Start
{
	public static class DependencyRegister
	{
		public static void RegisterAllDependencies()
		{
			var container = new Container();

			container.RegisterSingle<IOnionRepository, OnionRepository>();

			container.RegisterSingle<IOnionStockerService, FakeOnionStockerService>();

			// Set Unity as the Service Locator Provider
			ServiceLocator.SetServiceLocator( () => new SimpleInjectorServiceLocator( container ) );
		}
	}
}
