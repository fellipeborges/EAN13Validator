using EANValidator.Core;
using System;

namespace EANValidator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string VALID = "0040232916847";
            string INVALID = "73513536";
            IEanValidator eanValidator = new EanValidator();

            Console.WriteLine($"VALID: {eanValidator.Validate(VALID)}");
            Console.WriteLine($"INVALID: {eanValidator.Validate(INVALID)}");

            Console.ReadKey();
        }
    }
}
