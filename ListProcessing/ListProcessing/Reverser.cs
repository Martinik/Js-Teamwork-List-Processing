using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Reverser
    {
        public static List<string> Reverse(List<string> originalList)
        {
            originalList.Reverse();
            Console.WriteLine(string.Join(" ", originalList));
            return originalList;
        } 
    }
}
