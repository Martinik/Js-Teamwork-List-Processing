﻿using System;
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
                            Inserter.Insert(commandArgs, mainList);
                            break;
                        case "delete":
                            mainList = Deleter.Delete(mainList, commandArgs);
                            break;
                        case "roll":
                            Roller.Roll(mainList, commandArgs);
                            break;
                        case "sort":
                            mainList = Sorter.Sort(mainList, commandArgs);
                            break;
                        case "count":
                           mainList=Counter.Count(mainList, commandArgs);
                            break;
                        case "end":
                            Console.Writeline("finished");
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
