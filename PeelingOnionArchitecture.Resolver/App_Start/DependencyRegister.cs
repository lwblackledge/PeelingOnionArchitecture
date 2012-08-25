using PeelingOnionArchitecture.Core;
using PeelingOnionArchitecture.Core.Repositories;
using PeelingOnionArchitecture.Core.Services;
using PeelingOnionArchitecture.Infrastructure.Repositories;
using PeelingOnionArchitecture.Infrastructure.Services;
using SimpleInjector;
using System.Web;

[assembly: PreApplicationStartMethod(typeof(PeelingOnionArchitecture.Resolver.App_Start.DependencyRegister), "RegisterAllDependencies")]
namespace PeelingOnionArchitecture.Resolver.App_Start
{
   public static class DependencyRegister
   {
      public static void RegisterAllDependencies()
      {
         var container = new Container();

         container.Register<IOnionRepository, XmlOnionRepository>();

         container.Register<IOnionStockerService, FakeOnionStockerService>();

         // Set Unity as the Service Locator Provider
         ServiceLocator.SetServiceLocator(() => new SimpleInjectorServiceLocator(container));
      }
   }
}
