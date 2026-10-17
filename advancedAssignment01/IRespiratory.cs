using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal interface IRespiratory<T>
    {
        //What is a generic interface?
        //defines methods/properties that work with different data types

        void Add(T item);
        T Get(int id);
        void Delete(int id);
    }
}
