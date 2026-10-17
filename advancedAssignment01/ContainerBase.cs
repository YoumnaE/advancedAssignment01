using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace advancedAssignment01
{
    internal class ContainerBase<T> where T : Learn
    {
        //What is the base class constraint? Write an example.
        //parameter must be the specified base class or inherit from it

        public void Teach(T item)
        {
            item.Learning();
        }
    }
}
