using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_con_Interface_Y_Generics
{
    public interface List <T>
    {
        void addAtTail(T data);
        void addAtFront(T data);
        void remove(int index);
        void removeAll();
        void setAt(int index, T data);
        T getAt(int index);
        int getSize();
        Iterator<T> getIterator();
    }
}
