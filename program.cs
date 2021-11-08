using System;

namespace StacksLinkedList_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            QueuesLinkedList queues = new QueuesLinkedList();          //creating the queue object and calling it
            queues.Enqueue(56);
            queues.Enqueue(30);
            queues.Enqueue(70);
            queues.Display();
        }
    }
}
