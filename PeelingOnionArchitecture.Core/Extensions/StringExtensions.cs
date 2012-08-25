namespace PeelingOnionArchitecture.Core.Extensions
{
   public static class StringExtensions
   {
      public static string Trimmed( this string source )
      {
         if( source.NullOrEmpty() )
         {
            return string.Empty;
         }
         return source.Trim();
      }

      public static bool NullOrEmpty( this string source )
      {
         return ( source == null || source.Length == 0 );
      }

      public static bool NullOrWhitespace( this string source )
      {
         return source.Trimmed().NullOrEmpty();
      }
   }
}
