using System;

namespace LinkedList
{
    public class LinkedList
    {
        Node head = null;
        public void AddLast(object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                var newItem = new Node();
                newItem.data = data;
                current.next = newItem;
            }
        }

        public void AddFirst(object data)
        {
            Node current = new Node() { data = data, next = head };
            head = current;
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
