using System;
using SortedListInsert.Classes;

namespace SortedListInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.InsertSorted(5);
            list.PrintList();

            Console.ReadLine();

            list.InsertSorted(6);
            list.PrintList();

            Console.ReadLine();

            list.InsertSorted(4);
            list.PrintList();

            Console.ReadLine();

            list.InsertSorted(0);
            list.PrintList();

            Console.ReadLine();

            list.InsertSorted(5);
            list.PrintList();

            Console.ReadLine();
        }
    }
}
