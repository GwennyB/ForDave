using System;
using System.Collections.Generic;
using System.Text;

namespace SortedListInsert.Classes
{
    class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void InsertSorted (int value)
        {
            Node node = new Node(value);

;           Current = Head;

            // (edge case) if list is empty, insert node at Head
            if (Head == null)
            {
                Head = node;
                return;
            }
            // (edge case) if smaller than Head, insert node at front
            else if (Head.Value > node.Value)
            {
                node.Next = Head;
                Head = node;
                return;
            }

            // find insert location
            while ( Current.Next != null && Current.Next.Value < value)
            {
                Current = Current.Next;
            }

            // insert once location found
            node.Next = Current.Next;
            Current.Next = node;
        }


        public void PrintList ()
        {
            Current = Head;
            Console.Write("HEAD => ");

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} => null ");

        }
    }
}
