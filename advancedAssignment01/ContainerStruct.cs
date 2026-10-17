using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerStruct<T> where T : struct
    {
        //Q7: What is the 'struct' constraint? Write an example.
        //generic type parameter must be a non-nullable value type
        public T Value;

        public ContainerStruct(T value)
        {
            Value = value;
        }
    }
}
