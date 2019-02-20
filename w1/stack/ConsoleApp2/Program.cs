using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter numbers to sort");
                string entry = Console.ReadLine();
                if (entry == "" || entry.ToLower() == "exit")
                {
                    break;
                }
                var sorter = new Sorter.Sorter();
                sorter.Sort(entry);
                Console.WriteLine(sorter.ToString());
            }
        }
    }
}
