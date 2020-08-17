using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    class Node
    {
        public int info;
        public Node link;
        public int priority;

        public Node(int i,int pr)
        {
            info = i;
            priority = pr;
            link = null;
        }
    }
}
