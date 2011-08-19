namespace Solyutor.Extex.FluentStrings
{
    public static class StringExtensions
    {
         public static bool IsNullOrEmpty(this string self)
         {
             return string.IsNullOrEmpty(self);
         }

         public static bool IsNullOrEmptyOrWhiteSpace(this string self)
         {
             return string.IsNullOrEmpty(self) || string.IsNullOrWhiteSpace(self);
         }
    }
}