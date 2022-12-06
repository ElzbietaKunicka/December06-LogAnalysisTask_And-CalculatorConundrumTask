using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace December06
{
    // Log Analysis task
    ///*https://exercism.org/tracks/csharp/exercises/log-analysis*/
    public static class Extension
    {
        public static string SubstringAfter(this string firstEntry, string delimiter)
        {
            var str = firstEntry.Split(delimiter);
            var sliced = str[1..];
            var result = string.Concat(sliced);
            return result;
        }
        public static string SubstringBetween(this string firstEntry, string delimiter, string delimiter2)
        {
            var index1 = firstEntry.IndexOf(delimiter) +1;
            var index2 = firstEntry.IndexOf(delimiter2);
            var result = firstEntry[index1..index2];
            return result;
        }
        public static string Message(this string firstEntry)
        {
            return firstEntry.SubstringAfter(": ");
        }
        public static string LogLevel(this string firstEntry)
        {
            return firstEntry.SubstringBetween("[", "]");
        }
    }
}
