using PeelingOnionArchitecture.Core.Entities;
using System.Collections.Generic;

namespace PeelingOnionArchitecture.Core.Services
{
   public interface IOnionStockerService
   {
      IEnumerable<Store> GetStores();
      Store GetStoreById( int id );
      IEnumerable<Store> GetStoresByName( string name );
      IEnumerable<Store> GetStoresByOnion( Onion onion );
   }
}
