using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EANValidator.Core
{
    public class EanValidator : IEanValidator
    {
        /// <summary>
        /// Validates if the code is a valid 13 EAN code
        /// </summary>
        /// <param name="code">The code to be validated</param>
        /// <returns>True if it's valid, False otherwise</returns>
        public bool Validate(string code)
        {
            if (!CheckDigits(code))
            {
                return false;
            }

            // Garantee 14 digits
            code = code.PadLeft(14, '0');

            // Step 1: Multiply value of each position by 3 or 1
            int[] mult = Enumerable.Range(0, 13).Select(i => ((int)(code[i] - '0')) * ((i % 2 == 0) ? 3 : 1)).ToArray();

            // Step 2: Add results together to create sum
            int sum = mult.Sum();

            // Step 3: Subtract the sum from the nearest equal or higher multiple of ten
            return (10 - (sum % 10)) % 10 == int.Parse(code[13].ToString());
        }

        /// <summary>
        /// Check if all characters are digits and if it has 8, 12, 13 or 14 digits
        /// </summary>
        /// <returns>True if is valid, False otherwise</returns>
        private bool CheckDigits(string code)
        {
            var digitRegex = new Regex("^(\\d{8}|\\d{12,14})$");
            return digitRegex.IsMatch(code);
        }
    }
}
