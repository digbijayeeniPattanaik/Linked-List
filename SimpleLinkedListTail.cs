using System;

namespace LinkedList
{
    public class SimpleLinkedListTail
    {
        Node head = null;
        Node tail = null;
        public void AddLast(object data)
        {
            var newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                if (tail != null)
                {
                    tail.next = newItem;
                    tail = newItem;
                }
            }
        }

        public void AddFirst(object data)
        {
            Node current = new Node() { data = data, next = head };
            if (head == null)
            {
                head = current;
                tail = current;
            }
            else
            {
                current.next = head;
                head = current;
            }
        }

        public void ReadAllObject()
        {
            if (head == null)
                Console.WriteLine("Node is empty");
            else
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }
    }
}
