using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    public static class Roller
    {
        public static void Roll(List<string> mainList, List<string> commandArgs)
        {
            if (commandArgs.Count == 1)
            {
                Console.WriteLine("Error: invalid command");
            }
            else if (commandArgs[1].Equals("left"))
            {
                string firstElement = mainList[0];
                for (int i = 0; i < mainList.Count - 1; i++)
                {
                    mainList[i] = mainList[i + 1];
                }
                mainList[mainList.Count - 1] = firstElement;

                foreach (string el in mainList)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            else if (commandArgs[1].Equals("right"))
            {
                string lastElement = mainList[mainList.Count - 1];
                for (int i = mainList.Count - 1; i > 0; i--)
                {
                    mainList[i] = mainList[i - 1];
                }
                mainList[0] = lastElement;
                foreach (string el in mainList)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: invalid command");
            }
        }
    }
}
