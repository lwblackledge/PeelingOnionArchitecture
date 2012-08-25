using System;
namespace PeelingOnionArchitecture.Core.Entities
{
	[Serializable]
	public class Onion
	{
		public int Id { get; set; }
		public string CommonName { get; set; }
		public string Genus { get; set; }
		public string Species { get; set; }
		public string SubSpecies { get; set; }
		public string Color { get; set; }
	}
}
