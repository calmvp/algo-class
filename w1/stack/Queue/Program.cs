using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("Enter 1 to add a new name to the queue, 2 to dequeue the next customer, or 3 to view the queue list");
                string entry = Console.ReadLine();
                if (entry == "" || entry.ToLower() == "exit")
                {
                    break;
                }

                if (entry == "1")
                {
                    Console.WriteLine("Please enter a name");
                    string name = Console.ReadLine();
                    queue.Enqueue(name);
                }

                if (entry == "2")
                {
                    var next = queue.Dequeue();
                    Console.WriteLine($"{next} has been dequeued");
                }

                if (entry == "3")
                {
                    Console.WriteLine(queue.ToString());
                }
            }
        }
    }
}
