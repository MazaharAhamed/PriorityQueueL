using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PriorityQueue
{
    class PriorityQueueL
    {
        private Node front;

        public PriorityQueueL()
        {
            front = null;
        }

        public void Insert(int element,int elementpriority)
        {
            Node temp = new Node(element, elementpriority);

            if (isEmpty() || elementpriority<=front.priority)
            {
                temp.link = front;
                front = temp;
            }
            else
            {
                Node p = front;
                while(p.link!=null && p.link.priority<=elementpriority)
                {
                    p = p.link;
                }
                temp.link = p.link;
                p.link = temp;
            }
        }

        public bool isEmpty()
        {
            return (front == null);
        }

        public int Delete()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            else
            {
                x = front.info;
                front = front.link;
            }
            return x;
        }
        
        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return front.info;
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            Node p = front;
            Console.WriteLine("Queue is:");
            Console.WriteLine("Element Priority:");
            while(p!=null)
            {
                Console.WriteLine(p.info + " " + p.priority);
                p = p.link;
            }
            Console.WriteLine("");
        }

        public int Size()
        {
            int s = 0;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            Node p = front;
            while (p != null)
            {
                s++;
                p = p.link;
            }
            return s;
        }
    }
}
