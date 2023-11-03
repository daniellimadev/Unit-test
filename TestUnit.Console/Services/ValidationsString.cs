using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestUnit.Console.Services
{
    public class ValidationsString
    {
         public int ReturnQuantityCharacters(string text)
        {
            var numberCharacters = text.Length;
            return numberCharacters;
        }

        public bool ContainsCharacter(string text, string textWanted)
        {
            var contains = text.Contains(textWanted);
            return contains;
        }

        public bool TextTerminaWith(string text, string textWanted)
        {
            var ends = text.EndsWith(textWanted);
            return ends;
        }
    }
}