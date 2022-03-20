using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_con_Interface_Y_Generics.arrayList
{
    public class ArrayList<T> : List<T>
    {
        private static int DEFAULT_SIZE = 2;
        private T[] array;
        private int size;

        public ArrayList()
        {
            array = new T[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new T[size];
        }

        private void increaseArraySize()
        {
            T[] newArray = new T[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            array[size] = data;
            size++;
        }

        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            for (int i = size-1; i >= 0; i--)
            {
                array[i+1] = array[i];
            }

            array[0] = data;
            size++;
        }


        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[size - 1] = default(T);
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public void setAt(int index, T data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public T getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : default(T);
        }

        public int getSize()
        {
            return size;
        }

        public Iterator<T> getIterator() => new ArrayListIterator<T>(this);
    }
}
