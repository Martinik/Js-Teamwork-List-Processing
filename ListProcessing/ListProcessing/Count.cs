using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Counter
    {
        public static void Count(List<string>originalList, List<string>commandArgs)
        {
            string searched = commandArgs[1];
            int howMany = 0;

            foreach(var item in originalList)
            {
                if (item == searched)
                {
                    howMany++;
                }

                Console.WriteLine(howMany);
                Console.WriteLine();
              
            }

        }
    }
}

