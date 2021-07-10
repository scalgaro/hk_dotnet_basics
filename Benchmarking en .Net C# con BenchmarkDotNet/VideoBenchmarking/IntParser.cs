using System;
using System.Linq;

namespace VideoBenchmarking
{
    public static class IntParser
    {
        // "609" => 609
        
        public static int GetIntFromString(string intAsString)
        {
            int.TryParse(intAsString, out var number);
            return number;
        }
        
        // "609"
        public static int GetIntFromStringByAscii(string intAsString)
        {
            var array = intAsString.ToCharArray();

            var total = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                var placeValue = array.Length - i - 1;

                var multiplier = (int) Math.Pow(10, placeValue);
                
                total += (array[i] - '0') * multiplier;
            }
            
            return total;
        }
        
        public static int GetIntFromStringByAsciiWithoutMath(string intAsString)
        {
            var array = intAsString.ToCharArray();

            var total = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                var placeValue = array.Length - i - 1;

                var multiplier = (int) 10 ^ placeValue;
                
                total += (array[i] - '0') * multiplier;
            }
            
            return total;
        }
        
        public static int GetIntFromStringByAsciiWithoutVariables(string intAsString)
        {
            var array = intAsString.ToCharArray();

            var total = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                total += (array[i] - '0') * (10 ^ (array.Length - i - 1));
            }
            
            return total;
        }
        
        public static int GetIntFromStringByAsciiUsingLINQ(string intAsString)
        {
            var array = intAsString.ToCharArray();

            return array.Select((t, i) => (t - '0') * (10 ^ (array.Length - i - 1))).Sum();
        }
    }
}