using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_con_Interface_Y_Generics.linkedlist
{
    public class LinkedListIterator<T> : Iterator<T>
    {
        Node<T> currentNode;
        public LinkedListIterator(Node<T> starNode)
        {
            currentNode = starNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public T next()
        {
            T data = currentNode.data;
            currentNode = currentNode.next;

            return data;
        }
    }
}
