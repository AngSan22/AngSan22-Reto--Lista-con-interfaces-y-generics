using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_con_Interface_Y_Generics
{
    public interface Iterator <T>
    {
        Boolean hasNext();
        T next();
    }
}
