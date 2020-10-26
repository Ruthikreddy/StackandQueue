using System;

namespace DataStructure_LinkedListStackAndQueue
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calling functions from Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Operations on LinkedList Stack And Queue");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
