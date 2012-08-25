
using System.Collections.Generic;
using System.Linq;
using PeelingOnionArchitecture.Core.Entities;
using PeelingOnionArchitecture.Core.Repositories;
namespace PeelingOnionArchitecture.Infrastructure.Repositories
{
	public class OnionRepository : IOnionRepository
	{
		private IEnumerable<Onion> _onions = new List<Onion>
			{
				new Onion{Id=1, CommonName = "Green Onion", Color = "Green", Genus = "Allium", Species = "Cepa", SubSpecies = ""},
				new Onion{Id=2, CommonName = "Red Onion", Color = "Red", Genus = "Allium", Species = "Cepa", SubSpecies = ""},
				new Onion{Id=3, CommonName = "White Onion", Color = "White", Genus = "Allium", Species = "Cepa", SubSpecies = ""}
			};

		public Onion GetOnionById( int id )
		{
			return _onions.FirstOrDefault( x => x.Id == id );
		}

		public int SaveOnion( Onion onion )
		{
			_onions = _onions.Concat( new[] { onion } );
			return onion.Id;
		}

		public bool DeleteOnionById( int id )
		{
			if( _onions.Any( x => x.Id == id ) )
			{
				_onions = _onions.Where( x => x.Id != id );
				return true;
			}
			return false;
		}
	}
}
