using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_con_Interface_Y_Generics.linkedlist
{
    internal class LinkedList<T> : List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public void addAtTail(T data)
        {
            Node<T> node = new Node<T>(data);

            if (size == 0)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
            }
            tail = node;
            size++;
        }

        public void addAtFront(T data)
        {
            Node<T> node = new Node<T>(data);

            if (size == 0)
            {
                tail = node;
            }
            else
            {
                head.previous = node;
                node.next = head;
            }
            head = node;
            size++;

        }

        public Node<T> findNode(int index)
        {
            if (index < 0 || index > size)
            {
                return null;
            }

            Node<T> node = head;
            int currentIndex = 0;

            while (currentIndex != index)
            {
                currentIndex++;
                node = node.next;
            }

            return node;
        }

        public void remove(int index)
        {
            Node<T> node = findNode(index);

            if (node == null)
            {
                return;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else if (node == head)
            {
                head = head.next;
                head.previous = null;
            }
            else if (node == tail)
            {
                tail = tail.previous;
                tail.next = null;
            }
            else
            {
                node.previous.next = node.next;
                node.next.previous = node.previous;
            }

            size--;

        }

        public void removeAll()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void setAt(int index, T data)
        {
            Node<T> node = findNode(index);

            if (node != null)
            {
                node.data = data;
            }
        }

        public T getAt(int index)
        {
            Node<T>  node = findNode(index);

            return node == null ? default(T) : node.data; 
        }

        public int getSize()
        {
            return size;
        }

        public Iterator<T> getIterator() => new LinkedListIterator<T>(head);
    }
}
