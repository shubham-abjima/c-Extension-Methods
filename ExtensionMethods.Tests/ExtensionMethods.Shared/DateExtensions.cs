namespace ExtensionMethods.Shared
{
    public static class DateExtensions
    {
        /// <summary>
        /// Formats date to standard string 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Formatted String</returns>
        public static string Format(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ?
                dateTime.ToString("1yyMMdd") :
                dateTime.ToString("0yyMMdd");
        }
    }

    
}