using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class LinkedList
    {
        Node Head;
        public class Node
        {
            public int value;
            public Node next;

            public Node(int insert)
            {
                value = insert;
                next = null;
            }
        }

        public void Print()
        {
            while (Head != null)
            {
                Console.Write("{0}{1}",Head.value,'\t');
                Head = Head.next;
            }
        }

        public void Insert(int value, int position)
        {
            Node temp = Head;
            Node newNode = new Node(value);

            for (int i = 0; temp.next != null && i < position-1; i++)
            {
                temp = temp.next;
            }

            newNode.next = temp.next;
            temp.next = newNode;
        }

        public void InsertAtBegin(int value)
        {
            Node newNode = new Node(value);
            newNode.next = Head;
            Head = newNode;
        }

        public void InsertAtEnd(int value)
        {
            Node temp = Head;
            Node newNode = new Node(value);

            if (temp == null)
            {
                temp = newNode;
                return;
            }

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public bool Search(int compare)
        {
            Node temp = Head;

            while (temp != null)
            {
                if (temp.value == compare)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void Delete(int position)
        {
            Node temp = Head;
            Node next;

            if (position == 0)
            {
                temp = temp.next;

                return;
            }

            for (int i = 0; temp.next != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            if (temp.next == null || temp == null)
            {
                Console.WriteLine("This Node is not available");
                return;
            }

            next = temp.next.next;
            temp.next = next;
        }

        public void Sort()
        {
            Node current = Head;
            Node index;
            int temp;

            if (current == null)
            {
                return;
            }

            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    if (index.value < current.value)
                    {
                        temp = index.value;
                        index.value = current.value;
                        current.value = temp;
                    }

                    index = index.next;
                }

                current = current.next;
            }
        }

        
    }

    
}
