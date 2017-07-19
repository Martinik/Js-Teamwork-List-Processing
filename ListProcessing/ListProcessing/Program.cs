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
            List<string> mainList = Console.ReadLine().Split(new char[' '], StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> commandArgs = Console.ReadLine().Split(new char[' '], StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {

                switch (commandArgs[0])
                {
                    case "append":

                        break;
                    case "prepend":

                        break;
                    case "reverse":

                        break;
                    case "insert":

                        break;
                    case "delete":

                        break;
                    case "roll":

                        break;
                    case "sort":

                        break;
                    case "count":

                        break;
                    case "end":

                        break;

                    default:
                        //TODO: this
                        break;

                }

                commandArgs = Console.ReadLine().Split(new char[' '], StringSplitOptions.RemoveEmptyEntries).ToList();

            }



        }
    }
}
