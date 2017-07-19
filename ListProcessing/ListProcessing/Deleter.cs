using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    public static class Deleter
    {
        public static List<string> Delete(List<string> originalList, List<string> commandArgs)
        {
            int index;
            bool successfullyParsed = int.TryParse(commandArgs[1], out index);

            if (!successfullyParsed)
            {
                Console.WriteLine("Error: invalid command parameters");
                return originalList;
            }

            if (index < 0 || index > originalList.Count)
            {
                Console.WriteLine($"Error: invalid index {index}");
                return originalList;
            }

            originalList.RemoveAt(index);
            Console.WriteLine(string.Join(" ", originalList));

            return originalList;
        }
    }
}
