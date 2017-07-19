using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] stringSplitChars = new[] {' '};
            List<string> mainList = Console.ReadLine().Split(stringSplitChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(" ", mainList));
            List<string> commandArgs = Console.ReadLine().Split(stringSplitChars, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                if (commandArgs.Count == 0)
                {
                    Console.WriteLine("Error: invalid command");
                }
                else
                {
                    switch (commandArgs[0])
                    {
                        case "append":
                            Appender.Append(mainList,commandArgs);
                            break;
                        case "prepend":
                            Prepender.Prepend(mainList, commandArgs);
                            break;
                        case "reverse":
                            mainList = Reverser.Reverse(mainList);
                            break;
                        case "insert":

                            break;
                        case "delete":

                            break;
                        case "roll":
                            Roller.Roll(mainList, commandArgs);
                            break;
                        case "sort":
                            mainList = Sorter.Sort(mainList);
                            break;
                        case "count":

                            break;
                        case "end":

                            break;

                        default:
                            Console.WriteLine("Error: invalid command");
                            break;

                    }
                }

                commandArgs = Console.ReadLine().Split(stringSplitChars, StringSplitOptions.RemoveEmptyEntries).ToList();

            }



        }
    }
}
