using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Inserter
    {
        public static void Insert(int index, string input, List<string> originalList)
        {
            if (index < 0 || index > originalList.Count)
            {
                Console.WriteLine("Error: invalid index " + index + ".");
            }
            else if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                originalList.Insert(index, input);
                foreach (var item in originalList)
                {
                    Console.Write(item + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
