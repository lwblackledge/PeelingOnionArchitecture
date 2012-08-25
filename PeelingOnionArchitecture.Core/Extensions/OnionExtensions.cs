using PeelingOnionArchitecture.Core.Entities;

namespace PeelingOnionArchitecture.Core.Extensions
{
   public static class OnionExtensions
   {
      public static string GetName( this Onion onion )
      {
         return string.Format("{0} {1} (A. {2}{3})",
                              onion.Color,
                              onion.CommonName,
                              onion.Species,
                              onion.SubSpecies.NullOrEmpty() ? string.Empty : "var. " + onion.SubSpecies);
      }
   }
}
