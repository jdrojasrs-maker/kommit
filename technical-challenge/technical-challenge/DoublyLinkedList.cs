using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technical_challenge
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.prev = newNode;
                Head = newNode;
            }
            Count++;
        }

        public void InsertAtTail(int data)
        {
            Node newNode = new Node(data);
            if (Tail == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.prev = Tail;
                Tail = newNode;
            }
            Count++;
        }

        public void DeleteNode(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.data == data)
                {
                    if (current.prev != null)
                    {
                        current.prev.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.prev = current.prev;
                    }
                    else
                    {
                        Tail = current.prev;
                    }
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public void RemoveDuplicates()
        {
            if(Head == null) return;

            HashSet<int> seen = new HashSet<int>();
            Node current = Head;

            while (current != null)
            {
                if (seen.Contains(current.data))
                {
                    DeleteNode(current.data);
                }
                else
                {
                    seen.Add(current.data);
                }
                current = current.Next;
            }
        }

        public int Search(int data)
        {
            Node current = Head;
            int index = 0;
            while (current != null)
            {
                if (current.data == data)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void CountNodes()
        {
            Console.WriteLine($"Total nodes: {Count}");
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
