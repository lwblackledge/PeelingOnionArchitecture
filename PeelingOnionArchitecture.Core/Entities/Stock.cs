using System;
namespace PeelingOnionArchitecture.Core.Entities
{
   [Serializable]
   public class Stock
   {
      public int Id { get; set; }
      public Onion Onion { get; set; }
      public int Amount { get; set; }
   }
}
