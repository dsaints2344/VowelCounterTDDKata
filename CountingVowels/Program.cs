using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountingVowels
{
    public class VowelCounter
    {
        public Dictionary<string,int> Counter(string input) {

            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(input);
            string newInput = System.Text.Encoding.UTF8.GetString(tempBytes);

            string pattern = @"[aeiou]";
            Dictionary<string, int> vowels = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            foreach (Match match in Regex.Matches(newInput, pattern, RegexOptions.IgnoreCase))
            {
                int currentCount = 0;

                vowels.TryGetValue(match.Value.ToLower(), out currentCount);
                currentCount++;
                vowels[match.Value.ToLower()] = currentCount;

            }

            return vowels;

        }

        static void Main(string[] args)
        {
            

        }
    }


            

        


        
    
}
