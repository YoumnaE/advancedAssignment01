using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerConstructor<T> where T : new()
    {
        //Q9: What is the new() constraint? constructor constraint
        // generic type parameter has a public parameterless constructor

        public T Create()
        {
            return new T();
        }
    }
}
