using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestUnit.Console.Services
{
    public class ValidationsList
    {
        public List<int> RemoveNegativeNumbers(List<int> list)
        {
            var listNoNegatives = list.Where(x => x > 0);
            return listNoNegatives.ToList();
        }

        public bool ListContainsDeterminedNumber(List<int> list, int number)
        {
            var contains = list.Contains(number);
            return contains;
        }

        public List<int> MultiplyNumbersList(List<int> list, int number)
        {
            var multipliedlist = list.Select(x => x * number).ToList();
            return multipliedlist;
        }

        public int ReturnLargestNumberList(List<int> list)
        {
            return list.Max();
        }

        public int ReturnSmallNumberList(List<int> list)
        {
            return list.Min();
        }
    }
}