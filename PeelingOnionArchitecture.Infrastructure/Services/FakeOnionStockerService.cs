using PeelingOnionArchitecture.Core.Entities;
using PeelingOnionArchitecture.Core.Repositories;
using PeelingOnionArchitecture.Core.Services;
using System.Collections.Generic;
using System.Linq;

namespace PeelingOnionArchitecture.Infrastructure.Services
{
   public class FakeOnionStockerService : IOnionStockerService
   {
      private IList<Store> _fakeStoreDirectoryWebService;

      public FakeOnionStockerService( IOnionRepository onionRepo )
      {
         _fakeStoreDirectoryWebService = new List<Store> {
            new Store { Id = 1, 
               Address = "Here", 
               StoreName = "Store 1", 
               Stock = new List<Stock>{
                  new Stock{ Id = 1, Amount = 5, Onion = onionRepo.GetOnionById(1)},
                  new Stock{ Id = 2, Amount = 10, Onion = onionRepo.GetOnionById(2)},
               }
            },
            new Store { Id = 2, 
               Address = "There", 
               StoreName = "Store 2", 
               Stock = new List<Stock>{
                  new Stock{ Id = 1, Amount = 5, Onion = onionRepo.GetOnionById(1)},
                  new Stock{ Id = 2, Amount = 10, Onion = onionRepo.GetOnionById(2)},
               }},
         };
      }

      public IEnumerable<Core.Entities.Store> GetStores()
      {
         return _fakeStoreDirectoryWebService;
      }

      public Core.Entities.Store GetStoreById( int id )
      {
         return _fakeStoreDirectoryWebService.FirstOrDefault(x => x.Id == id);
      }

      public IEnumerable<Core.Entities.Store> GetStoresByName( string name )
      {
         return _fakeStoreDirectoryWebService.Where(x => x.StoreName.Contains(name));
      }

      public IEnumerable<Core.Entities.Store> GetStoresByOnion( Core.Entities.Onion onion )
      {
         return _fakeStoreDirectoryWebService.Where(x => x.Stock.Any(y => y.Onion.Id == onion.Id));
      }
   }
}
