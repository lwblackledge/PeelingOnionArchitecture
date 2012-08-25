using System;
using System.Collections.Generic;
using System.Threading;

namespace PeelingOnionArchitecture.Core.Entities
{
   [Serializable]
   public class Store
   {
      public int Id { get; set; }
      public string StoreName { get; set; }
      public string Address { get; set; }

      private IEnumerable<Stock> _stock;
      public IEnumerable<Stock> Stock
      {
         get { return LazyInitializer.EnsureInitialized(ref _stock); }
         set { _stock = value; }
      }

   }
}
