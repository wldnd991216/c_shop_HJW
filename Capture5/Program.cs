using System;
using System.Collections.Generic;

namespace a201827061_HJW
{
    class Program
    {
        enum E { Red, Green, Blue };
        static void Main(String[] args)
        {
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + a);

            GenericList<int> iList = new GenericList<int>();
            Console.WriteLine("iList : "+iList.GetLast());

            GenericList<string> sList = new GenericList<string>();
            Console.WriteLine("sList : " + sList.GetLast());
        }
    }

    public class GenericList<T>
    {
        private class Node
        {
            public T data;
            public Node Next;
        }

        private Node head = default;
        
        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.data = t;
            head = newNode;
        }

        public void printList()
        {
            for (Node ptr = head; ptr != default; ptr = ptr.Next)
                Console.Write(ptr.data + " ");
            Console.WriteLine();

        }

        public T GetLast()
        {
            T temp = default(T);

            Node current = head;
            while (current != null)
            {
                temp = current.data;
                current = current.Next;
            }
            return temp;
        }
    }

}