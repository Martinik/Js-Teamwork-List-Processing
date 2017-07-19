using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    static class Inserter
    {
        public static void Insert(List<string> commandArgs, List<string> originalList)
        {
            if (commandArgs.Count<3|| commandArgs.Count>3)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            //int index, string input
            else if (int.Parse(commandArgs[1]) < 0 || int.Parse(commandArgs[1]) > originalList.Count)
            {
                Console.WriteLine("Error: invalid index " + int.Parse(commandArgs[1]) + ".");
            }
            else if (String.IsNullOrEmpty(commandArgs[2]))
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                originalList.Insert(int.Parse(commandArgs[1]), commandArgs[2]);
                foreach (var item in originalList)
                {
                    Console.Write(item + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
