using PeelingOnionArchitecture.Core.Entities;

namespace PeelingOnionArchitecture.Core.Repositories
{
   public interface IOnionRepository
   {
      Onion GetOnionById( int id );
      int SaveOnion( Onion onion );
      bool DeleteOnionById( int id );
   }
}
