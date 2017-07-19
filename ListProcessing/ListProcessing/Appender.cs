using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Appender
    {
        public static void Append(List<string> originalList, List<string> commandArgs)
        {
            originalList.Add(commandArgs[1]);
            foreach (var item in originalList)
            {
                Console.Write(item+' ');
            }
            Console.WriteLine();
        }
    }
}
