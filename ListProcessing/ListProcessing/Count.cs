namespace ListProcessing
{
    static class Counter
    {
        public static List<string> Count(List<string>originalList, List<string>commandArgs)
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
