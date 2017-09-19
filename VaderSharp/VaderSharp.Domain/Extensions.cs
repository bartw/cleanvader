using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaderSharp.Domain
{
    internal static class Extensions
    {
        /// <summary>
        /// Determine if word is ALL CAPS
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsAllCapitals(this string word)
        {
            return !word.Any(char.IsLower);
        }

        /// <summary>
        /// Removes punctuation from word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string RemovePunctuation(this string word)
        {
            return new string(word.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
