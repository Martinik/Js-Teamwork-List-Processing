using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Prepender
    {
        public static void Prepend(List<string> originalList, List<string> commandArgs)
        {
            originalList.Insert(0,commandArgs[1]);

            foreach (var item in originalList)
            {
                Console.Write(item + ' ');
            }
            Console.WriteLine();
        }
    }
}
