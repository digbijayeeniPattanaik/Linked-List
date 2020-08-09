using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinkedList = new LinkedList();
            LinkedList.AddFirst(5);
            LinkedList.AddLast(6);
            LinkedList.AddLast(7);
            LinkedList.AddLast(8);
            LinkedList.ReadAllObject();

            var SimpleLinkedListTail = new SimpleLinkedListTail();
            SimpleLinkedListTail.AddFirst(5);
            SimpleLinkedListTail.AddLast(6);
            SimpleLinkedListTail.AddLast(7);
            SimpleLinkedListTail.AddLast(8);
            SimpleLinkedListTail.ReadAllObject();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
