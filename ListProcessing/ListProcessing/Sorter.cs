using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    public static class Sorter
    {
        public static List<string> Sort(List<string> originalList)
        {
            originalList.Sort();
            Console.WriteLine(string.Join(" ", originalList));
            return originalList;
        } 
    }
}
