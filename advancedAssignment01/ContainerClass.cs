using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerClass<T> where T : class
    {
        //Q8:generic type parameter must be a reference type
        public T Value;

        public ContainerClass(T value)
        {
            Value = value;
        }
    }
}
